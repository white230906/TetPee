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
        if (result == null)
        {
            throw new Exception("Not found");
        }
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
                Body = $@"
                <!DOCTYPE html>
                <html>
                <head>
                    <meta charset='UTF-8'>
                    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                </head>
                <body style='margin:0; padding:0; background-color:#f4f6f8; font-family:Arial, sans-serif;'>

                    <table width='100%' cellpadding='0' cellspacing='0' style='background-color:#f4f6f8; padding:20px;'>
                        <tr>
                            <td align='center'>
                                
                                <!-- Container -->
                                <table width='600' cellpadding='0' cellspacing='0' style='background:#ffffff; border-radius:10px; overflow:hidden; box-shadow:0 4px 10px rgba(0,0,0,0.05);'>

                                    <!-- Header -->
                                    <tr>
                                        <td style='background:#4CAF50; padding:20px; text-align:center; color:white; font-size:24px; font-weight:bold;'>
                                            Welcome to TetPee 🎉
                                        </td>
                                    </tr>

                                    <!-- Body -->
                                    <tr>
                                        <td style='padding:30px; color:#333333; font-size:16px; line-height:1.6;'>

                                            <p>Dear <strong>{request.FirstName} {request.LastName}</strong>,</p>

                                            <p>
                                                Thank you for registering as a <strong>seller</strong> on TetPee.
                                                We are thrilled to have you join our growing marketplace!
                                            </p>

                                            <p>
                                                You can now start listing your products, managing your store, 
                                                and reaching thousands of customers.
                                            </p>

                                            <!-- Button -->
                                            <p style='text-align:center; margin:30px 0;'>
                                                <a href='#' 
                                                   style='background-color:#4CAF50; color:white; padding:12px 25px; text-decoration:none; border-radius:5px; font-weight:bold; display:inline-block;'>
                                                    Go to Dashboard
                                                </a>
                                            </p>

                                            <p>
                                                If you have any questions, feel free to contact our support team.
                                            </p>

                                            <p>
                                                Best regards,<br/>
                                                <strong>The TetPee Team</strong>
                                            </p>

                                        </td>
                                    </tr>

                                    <!-- Footer -->
                                    <tr>
                                        <td style='background:#f0f0f0; padding:15px; text-align:center; font-size:12px; color:#777;'>
                                            © 2026 TetPee. All rights reserved.
                                        </td>
                                    </tr>

                                </table>

                            </td>
                        </tr>
                    </table>

                </body>
                </html>
                "
            });
            
            if(sellerResult > 0) return "Add Seller successfully";
            
            return Message.FailToAddSeller;
        }

        return Message.FailToAddSeller;
    }
}