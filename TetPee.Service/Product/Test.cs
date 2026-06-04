using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using TetPee.Repository;
using Xunit;

namespace TetPee.Service.Product;

public class Test
{
   // private readonly Mock<IHttpContextAccessor> _MockHttpContext;

   private Mock<IHttpContextAccessor> CreateMockHttpContext(string sellerId)
   {
       var fakeClaims = new List<Claim>
       {
           new Claim("SellerId", sellerId),
           new Claim(ClaimTypes.Email, "test@gmail.com")
       };
       var fakeIdentity = new ClaimsIdentity(fakeClaims, "Test");
       var fakePrincipal = new ClaimsPrincipal(fakeIdentity);
       var realHttpContext = new DefaultHttpContext{ User = new ClaimsPrincipal(fakePrincipal) };
       //realHttpContext.User = fakePrincipal;
       var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
       mockHttpContextAccessor.Setup(x => x.HttpContext).Returns(realHttpContext);
       
       return mockHttpContextAccessor;
   }
   
    [Fact]
    public async Task CreateProduct_Test_WithError_ExistProduct()
    {
        
        //
        var fakeSellerId = Guid.NewGuid();
        var mockHttpContextAccessor = CreateMockHttpContext(fakeSellerId.ToString());
        //  
        var newListProduct = new List<Repository.Entity.Product>();
        var newProduct = new Repository.Entity.Product()
        {
            Id = Guid.NewGuid(),
            Name = "Test",
            Price = 100,
            Description = "Test",
        };
        newListProduct.Add(newProduct);
        
        //var options = new DbContextOptionsBuilder<AppDbContext>().Options;
        var mockDbContext = new Mock<AppDbContext>(new DbContextOptions<AppDbContext>());
        mockDbContext.Setup(x => x.Products).ReturnsDbSet(newListProduct);
        mockDbContext.Setup(x => x.Sellers).ReturnsDbSet(new List<Repository.Entity.Seller>());
        
        var service = new Service(mockDbContext.Object, mockHttpContextAccessor.Object);
        
        
        var result = new Request.CreateProductRequest()
        {
            Name = "Test",
            Price = 100,
            Description = "Test",
            CategoryIds = null,
        };
        var exception = await Assert.ThrowsAsync<Exception>(() => service.CreateProduct(result));
        Assert.Equal("Product with the same name already exits", exception.Message);
        
    }

    [Fact]
    public async Task CreateProduct_Test_WithError_NotExistSeller()
    {
        var fakeSellerId = Guid.NewGuid().ToString();
        var fakeClaims = new List<Claim>
        {
            new Claim("SellerId", fakeSellerId),
            new Claim(ClaimTypes.Email, "test@gmail.com"),
        };
        var fakeIdentity = new ClaimsIdentity(fakeClaims, "Test");
        var fakePrincipal = new ClaimsPrincipal(fakeIdentity);
        
        var realHttpContext = new DefaultHttpContext();
        realHttpContext.User = fakePrincipal;
        
        var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
        mockHttpContextAccessor.Setup(x => x.HttpContext).Returns(realHttpContext);
        
        var mockDbContext = new Mock<AppDbContext>(new DbContextOptions<AppDbContext>());
        mockDbContext.Setup(x => x.Products).ReturnsDbSet(new List<Repository.Entity.Product>());
        mockDbContext.Setup(x => x.Sellers).ReturnsDbSet(new List<Repository.Entity.Seller>());
        var service = new Service(mockDbContext.Object, mockHttpContextAccessor.Object);
        var result = new Request.CreateProductRequest()
        {
            Name = "Test",
            Price = 100,
            Description = "Test",
            CategoryIds = null,
        };
        var exception = await Assert.ThrowsAsync<Exception>(() => service.CreateProduct(result));
        Assert.Equal("Seller not exist", exception.Message);
    }
}