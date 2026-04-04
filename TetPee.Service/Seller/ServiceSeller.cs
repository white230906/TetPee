using Microsoft.EntityFrameworkCore;
using TetPee.Repository;
using TetPee.Service.MailService;
using TetPee.Service.User;
using IService = TetPee.Service.MailService.IService;

namespace TetPee.Service.Seller;

public class ServiceSeller: IServiceSeller 
{
    private readonly AppDbContext _dbContext;
    private readonly IService _mailService;
    
    public ServiceSeller(AppDbContext dbContext, IService mailService)
    {
        _dbContext = dbContext;
        _mailService = mailService;
    }
    
    public async Task<Base.Response.PageResult<ResponseSeller.GetSellerResponse>> GetSellers(string? searchTerm, int pageSize, int pageIndex)
    {//đi từ role thì nó chưa tối ưu performance vì trong user có nhiều role mà
        var query = _dbContext.Users.Where(x => x.Role == "Seller");
        if (searchTerm != null)
        {
            query = query.Where(x => x.FirstName.Contains(searchTerm));
        }
        query = query.OrderBy(x => x.FirstName);
        
        query = query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize);

        var selectedQuery = query.Select(x => new ResponseSeller.GetSellerResponse()
        {
            FirstName = x.FirstName,
            LastName = x.LastName,
            Email = x.Email,
            ImageUrl = x.ImageUrl,
            TaxCode = x.Seller!.TaxCode,//à tôi biết rồi
            CompanyName = x.Seller.CompanyName,
        });

        var listResult = await selectedQuery.ToListAsync();
        var totalItems = listResult.Count;

        var result = new Base.Response.PageResult<ResponseSeller.GetSellerResponse>()
        {
            Items = listResult,
            PageIndex =  pageIndex,
            PageSize = pageSize,
            TotalItems = totalItems,
        };
        return result;

    }

    public async Task<ResponseSeller.GetSellerDetailResponse> GetSellersById(Guid sellerId)
    {
        var query = _dbContext.Users.Where(x => x.Id == sellerId 
                                                            && x.Role == "Seller");
        var selectedQuery = query
            .Select(x => new ResponseSeller.GetSellerDetailResponse()
        {
            Email = x.Email,
            FirstName = x.FirstName,
            LastName = x.LastName,
            ImageUrl = x.ImageUrl,
            PhoneNumber = x.PhoneNumber,
            Address = x.Address,
            DateOfBirth =  x.DateOfBirth,
            TaxCode =  x.Seller.TaxCode,
            CompanyName = x.Seller.CompanyName,
            CompanyAddress = x.Seller.CompanyAddress,
        });

        var result = await selectedQuery.FirstOrDefaultAsync();
        return result;
    }

    public async Task<string> CreateSeller(RequestSeller.CreateSellerRequest request)
    {
        //1.check Email ton tai ch
        var existingUserQuery = _dbContext.Users.Where(x => x.Email == request.Email);
        bool isExistUser = await existingUserQuery.AnyAsync();
        if (isExistUser)
        {
            throw new Exception(Message.UserExistWithMail);
        }

        var user = new Repository.Entity.User()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            HashedPassword = request.Password,
            Role = "Seller",
        };
        _dbContext.Add(user);
        var result = await _dbContext.SaveChangesAsync();
        if (result > 0)
        {
            var seller = new Repository.Entity.Seller()
            {
                CompanyAddress = request.CompanyAddress,
                CompanyName = request.CompanyName,
                TaxCode = request.TaxCode,
                UserId = user.Id,
            };
            _dbContext.Add(seller);
            var sellerResult = await _dbContext.SaveChangesAsync();

            await _mailService.SendMail(new MailContent()
            {
                To = request.Email,
                Subject = "Welcome to TetPee",
                Body = $"Dear {request.FirstName} {request.LastName}, \n\n" +
                "Thank you for registering as a seller on TetPee. We are excited hihi",
            });
            
            if(sellerResult > 0) return "Add Seller successfully";
            
            return Message.FailToAddSeller;
        }

        return Message.FailToAddSeller;
    }
}