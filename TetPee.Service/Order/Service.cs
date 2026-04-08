using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TetPee.Repository;
using TetPee.Repository.Entity;

namespace TetPee.Service.Order;

public class Service: IService
{
    private readonly AppDbContext _dbContext;
    private readonly IHttpContextAccessor _httpContext;

    public Service(AppDbContext dbContext, IHttpContextAccessor httpContext)
    {
        _dbContext = dbContext;
        _httpContext = httpContext;
    }
    
    public async Task<Response.CreateOrderResponse> CreateOrder(Request.CreateOrderRequest request)
    {
        var userId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "UserId")?.Value;
        var userIdGuid = Guid.Parse(userId!);
        
        //List Object -> List Guid => Mapping List thì xài Select
        var productIts = request.Products.Select(x => x.ProductId).Distinct().ToList();
        //handler trường hợp người ta truyền vô linh tinh, tránh xung đột khóa ngoại
        var query = _dbContext.Products.Where(x => productIts.Contains(x.Id));
        
        var productCount = await query.CountAsync();
        if (productCount != productIts.Count)
        {
            throw new Exception("Some products are not identical");
        }
        
        var result = await query.ToListAsync();

        decimal totalAmount = 0;
        
        foreach (var prod in result)
        {
            //Tìm trong list giỏ sàng sản phẩm để tìm số lượng mà khách hàng muốn mua!
            var quantity = request.Products.First(x => x.ProductId == prod.Id).Quantity;

            if (quantity <= 0)
            {
                throw new Exception($"Quantity of product {prod.Id} must be greater than 0");
            }
            
            totalAmount += prod.Price * quantity;
        }

        if (totalAmount <= 0)
        {
            throw new Exception("Total amount must be greater than 0");
        }

        var order = new Repository.Entity.Order()
        {
            Id = Guid.NewGuid(),
            UserId = userIdGuid,
            TotalAmount = totalAmount,
            Address = request.Address,
            Status = "Pending",
            CreatedAt = DateTime.UtcNow,
        };
        _dbContext.Add(order);
        await _dbContext.SaveChangesAsync();
        
        List<OrderDetail> orderDetails = new List<OrderDetail>();
        foreach (var prod in result)
        {
            var quantity = request.Products.First(x => x.ProductId == prod.Id).Quantity;
            
            var orderDetail = new OrderDetail()
            {
                Id = Guid.NewGuid(),
                OrderId = order.Id,
                ProductId = prod.Id,
                Quantity = quantity,
                UnitPrice = prod.Price,
            };
            
            orderDetails.Add(orderDetail);
        }

        if (orderDetails.Any())
        {
            _dbContext.AddRange(orderDetails);
            await _dbContext.SaveChangesAsync();
        }

        string description = $"TETPEE-{order.Id}";

        var response = new Response.CreateOrderResponse()
        {
            OrderId = order.Id,
            TotalAmount = order.TotalAmount,
            BankName = "MBBank",
            BankAccount = "0384875317",
            Description =description ,
            QRCodee = ""
        };
        
        string qrCode = $"https://qr.sepay.vn/img?" +
                        $"acc={response.BankAccount}&" +
                        $"bank={response.BankName}&" +
                        $"amount={(int)totalAmount}&" +
                        $"des={description}&" +
                        $"template=qronly";
        response.QRCodee = qrCode;
        return response;
    }

    public async Task SepayWebhookHandler(Request.SepayWebhookRequest request)
    {
        var description = request.Code;//TETPEEORDERID,
        //code và tổng số tiền là quan trọng trong callbac aPI
        
        var raw = description.Replace("TETPEE", ""); // => ORDERID
        
        Guid? orderId = null;
        if (raw.Length == 32) // mặc định 1 Guid sẽ có 32 ký tự nếu không có gạch nối,
        //nếu không có dấu gạch nối thì sẽ có 36 ký tự
        {
            //Vì ORDERID theo format là không có dấu gạch ngang, nên format theo dấu gạch ngang
            //format của DB của mình
            //Example: 12b7b0ce-b395-4e7c-a3ec-7f27d485e10a
            var formatted = 
                            $"{raw.Substring(0, 8)}-" +
                            $"{raw.Substring(8, 4)}-" +
                            $"{raw.Substring(12, 4)}-" +
                            $"{raw.Substring(16, 4)}-" +
                            $"{raw.Substring(20, 12)}";
            //Id nhưng mà hiện tại nó đang theo string, chuẩn GUID rồi đó
            if (Guid.TryParse(formatted, out var guid))
            {
                orderId = guid;
            }
            //orderId  = Guid.Parse(formatted)
        }
        else
        {
            throw new Exception("Invalid exception format");
        }

        if (orderId == null)
        {
            throw new Exception("Order not found in description");
        }
        //kiểm tra order có tồn tại trong DB hay không
        var query = _dbContext.Orders.Where(x => x.Id == orderId);
        var order = await query.FirstOrDefaultAsync();
        if (order == null)
        {
            throw new Exception("Order not found");
        }
        //nếu tồn tại mà status khác pending thì tức là đã xử lí rồi mà
        if (order.Status != "Pending")
        {
            throw new Exception("Order already progressed");
        }

        if (order.TotalAmount != request.TransferAmount)
        {
            throw new Exception("Invalid transfer amount");
        }
        order.Status = "Completed";
        _dbContext.Update(order);
        await _dbContext.SaveChangesAsync();
    }
}
//Bản chất của SePay
// Sẽ là 1 thằng ngồi lắng nghe hết tất cả các giao dịch của mình trong tài khoản
//và mình có thể làm một thứ là nếu có giao dịch nào chuyển đến thì gọi 1 API callback
// vầ không phải giao dịch nào cũng là giao dịch của hệ thống mình, 
    // giao dịch trả tiền nợ từ bạn A -> Call API
    // giao dịch mua hàng từ hệ thống TetPee -> Call API
    // Giao dịch trả tiền cổ tức -> Call API
    
    //Call APi của ai thì tùy mọi người setup với hệ thống của mình, nhưng ở đây anh muốn
    //là nó call API của mình để thông báo là đã ck thành công 
    
    //Không phải tất cả giao dịch nào cũng là giao dịch của hệ thống mình, vậy thì để
        //phân bịch giao dịch của mình, thì chúng ta sẽ tạo ra 1 dấu ấn riêng, làm dấu
        