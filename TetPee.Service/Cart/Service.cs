using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TetPee.Repository;
using TetPee.Repository.Entity;

namespace TetPee.Service.Cart;

public class Service: IService
{
    private readonly AppDbContext _dbContext;
    private readonly IHttpContextAccessor _httpContext;

    public Service(AppDbContext dbContext, IHttpContextAccessor httpContext)
    {
        _dbContext = dbContext;
        _httpContext = httpContext;
    }

    public async Task CreateCart()
    {
        var userId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "UserId")?.Value;
        
        var userIdGuid = Guid.Parse(userId!);
        
        var query = _dbContext.Carts.Where(x => x.UserId == userIdGuid);
        
        var isExist = await query.AnyAsync();
        if (isExist)
        {
            throw new Exception("Cart already exist");
        }
        var cart = new Repository.Entity.Cart()
        {
            UserId = userIdGuid,
        };
        
        _dbContext.Add(cart);
        await _dbContext.SaveChangesAsync();    
    }

    public async Task AddProductToCart(Request.AddProductToCartRequest request)
    {
        var userId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "UserId")?.Value;
        var userIdGuid = Guid.Parse(userId!);

        var query = _dbContext.Carts.Where(x => x.UserId == userIdGuid);
        
       var cart = await query.FirstOrDefaultAsync();
       //nếu cart không tồn tại thì tạo mới dùm nó luôn
        if (cart == null)
        {
           // throw new Exception("Cart not exist");
           cart = new Repository.Entity.Cart()
           {
               Id  = Guid.NewGuid(),
               UserId = userIdGuid,
           };
        
           _dbContext.Add(cart);
           await _dbContext.SaveChangesAsync();
        }
        //kiểm tra thử product nó add nào có nằm trong product của mình không và cart đó có tồn tại không
        var productQuery = _dbContext.CartDetails.Where(
             x => x.CartId == cart.Id && x.ProductId == request.ProductId);
        var cartExist = await productQuery.FirstOrDefaultAsync();
        //nếu tồn tại thì update quantity
        if (cartExist != null)
        {
            cartExist.Quantity += request.Quantity; 
            _dbContext.Update(cartExist);
            await _dbContext.SaveChangesAsync();
            return;
        }
        //có cart, có product thì tạo CartDetail luôn
        var cartDetail = new CartDetail()
        {
            CartId = cart.Id,
            ProductId = request.ProductId,
            Quantity = request.Quantity,
        };
        
        _dbContext.Add(cartDetail);
        await _dbContext.SaveChangesAsync();
    }

    public async Task RemoveProductFromCart(Request.RemoveProductFromCartRequest request)
    {
        var userId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "UserId")?.Value;
        var userIdGuid = Guid.Parse(userId!);
        
        //xóa ở Product ở Cart của User nào
        var query = _dbContext.CartDetails.Where(
            x => x.Cart.UserId == userIdGuid && x.ProductId == request.ProductId);
        var cartDetail = await query.FirstOrDefaultAsync();
        if (cartDetail == null)
        {
            throw new Exception("Product not exist in cart");
        }
        _dbContext.Remove(cartDetail);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Response.ProductResponse>> GetCart()
    {
        var userId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "UserId")?.Value;
        var userIdGuid = Guid.Parse(userId!);

        var query = _dbContext.CartDetails
            .Where(x => x.Cart.UserId == userIdGuid)
            .Select(x => new Response.ProductResponse
            {
                Name = x.Product.Name,
                Description = x.Product.Description,
                Price = x.Product.Price,
                Url = x.Product.UrlImage,
                Quantity = x.Quantity
            });

        var result = await query.ToListAsync();
        return result;
    }
}