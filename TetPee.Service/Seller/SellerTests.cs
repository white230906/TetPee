
using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using TetPee.Repository;
using TetPee.Service.MailService;
using Xunit;

namespace TetPee.Service.Seller;

public class SellerServiceTests
{
    private readonly Mock<IService> _mockMailService;

    [Fact]
    public async Task GetSellerById_Check_ReturnCorrectResponse()
    {
        var idTarget = Guid.NewGuid();
        var mockUser = new List<Repository.Entity.User>
        {
            new()
            {
                Id = idTarget,
                FirstName = "Test",
                LastName = "Test",
                Email = "emailtest@gmail.com",
                HashedPassword = "password",
                Role = "Seller",
                Seller = new Repository.Entity.Seller()
                {
                    CompanyAddress =  "Test",
                    CompanyName = "Test",
                }
            },
        };

        var options = new DbContextOptionsBuilder<AppDbContext>().Options;
        //tạo ra một Object giả kế thừa từ AppDbContext này
        var mockDbContext = new Mock<AppDbContext>(options);
        //khi ai gọi db này thì trả ra cái user fake của mình vào
        mockDbContext.Setup(x => x.Users).ReturnsDbSet(mockUser);
        var mockEmailService = new Mock<IService>();
        var service = new ServiceSeller(mockDbContext.Object, mockEmailService.Object);
        var result = await service.GetSellersById(idTarget);
        //
        Assert.Equal("Test",result.CompanyAddress);
        
    }

    [Fact]
    public async Task GetSellerById_Check_ThrowException()
    {
        var targetId = Guid.NewGuid();
        var mockUser = new List<Repository.Entity.User>();
        var newUser = new Repository.Entity.User()
        {
            Id = targetId,
            FirstName = "Test",
            LastName = "Test",
            Email = "test@gmail.com",
            HashedPassword = "password",
            Role = "User",
        };
        mockUser.Add(newUser);
        
        var mockEmailService = new Mock<IService>();
        var options = new DbContextOptionsBuilder<AppDbContext>().Options;
        var mockDbContext = new Mock<AppDbContext>(options);
        mockDbContext.Setup(x => x.Users).ReturnsDbSet(mockUser);
        var service = new ServiceSeller(mockDbContext.Object, mockEmailService.Object);
        var exception = await Assert.ThrowsAsync<Exception>(() => service.GetSellersById(targetId));
        Assert.Equal("Not found", exception.Message);
    }
}

    