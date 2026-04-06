namespace TetPee.Service.Order;

public class Request
{
    public class CreateOrderRequest
    {   
        public string Address { get; set; }
        public string PhoneNumber {get; set;}
        public List<ProductOrderRequest> Products {get; set;}
    }
    
    public class ProductOrderRequest
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
    
    //Tạo đơn hàng (Giả sử hệ thống mình, muốn đặt hàng thì phải chuyển khoảng trước)
        //setup chuyển khoảng để thành công (bằng tiền thiệt), để xác nhận đơn hàng
            //đã được đặt
        //Nếu tạo ra đơn hàng mà không chuyển khoảng liền, thì đơn hàng sẽ bị hủy sau 15p
        
    
    //Huy don hang
    //cap nhat don hang
}