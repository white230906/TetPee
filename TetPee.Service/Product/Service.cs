using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TetPee.Repository;
using TetPee.Repository.Entity;

namespace TetPee.Service.Product;

public class Service: IService
{
    private readonly AppDbContext _dbContext;
    private readonly IHttpContextAccessor _httpContext;
    //thằng này chứa thông tin của req
    // giúp lấy payload trong token
    
    public Service(AppDbContext dbContext, IHttpContextAccessor httpContext)
    {
        _dbContext = dbContext;
        _httpContext = httpContext;
    }
    public async Task<string> CreateProduct(Request.CreateProductRequest request)
    {
        var sellerId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "SellerId")?.Value;
        //trong request hiện tại lấy claims của user đó 
        var sellerIdGuid = Guid.Parse(sellerId!);
        //chuyển về dạng Guild
        
        var existingProductQuery =  _dbContext.Products.Where
            (x => x.Name.ToLower().Trim() == request.Name.ToLower().Trim());

        bool isExistProduct = await existingProductQuery.AnyAsync();

        if (isExistProduct)
        {
            throw new Exception("Product with the same name already exits");
        }
        var existingSellerQuery = _dbContext.Sellers.Where(x => x.Id == sellerIdGuid);
        bool isExistSeller = await existingSellerQuery.AnyAsync();
        if (!isExistSeller)
        {
            throw new Exception("Seller not exist");
        }

        var product = new Repository.Entity.Product()
        {
            Description = request.Description,
            Name = request.Name,
            Price =  request.Price,
            SellerId = sellerIdGuid
        };
        _dbContext.Add(product);
        var sellerResult = await _dbContext.SaveChangesAsync();
        if (request.CategoryIds != null && request.CategoryIds.Count > 0)
        {
            var productCateList = request.CategoryIds.Select(x => new ProductCategory()
            {
                CategoryId = x,
                ProductID = product.Id
            });
            // var productCateList1 = new List<ProductCategory>();
            // foreach (var id in request.CategoryIds)
            // {
            //     var productCategory = new ProductCategory()
            //     {
            //         CategoryId = id,
            //         ProductID = product.Id
            //     };
            //     productCateList1.Add(productCategory);
            //     await _dbContext.SaveChangesAsync();
            // }    
        _dbContext.AddRange(productCateList);
        await _dbContext.SaveChangesAsync();
        }

        if (sellerResult > 0) return Response.Messages.CreateProductSuccess;
        return Response.Messages.FailedToCreateProduct;
    }
}