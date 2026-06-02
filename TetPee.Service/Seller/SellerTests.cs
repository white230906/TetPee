using Microsoft.EntityFrameworkCore;
using Moq;
using TetPee.Repository;
using TetPee.Service.MailService;
using Xunit;

namespace TetPee.Service.Seller;

public class SellerTests
{
   private readonly Mock<AppDbContext> _dbContext;
   private readonly Mock<IService> _mailService;
   private readonly ServiceSeller _sellerService;
   
   public SellerTests()
   {
      _dbContext = new Mock<AppDbContext>();
      _mailService = new Mock<IService>();
      _sellerService = new ServiceSeller(_dbContext.Object, _mailService.Object);
   }

   [Fact]
   public void GetSelletsById_ThrowsException_Test()
   {
      
   }
}

    