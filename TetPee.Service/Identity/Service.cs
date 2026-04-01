using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TetPee.Repository;
using TetPee.Service.JwtService;

namespace TetPee.Service.Identity;

public class Service: IService
{
    private readonly JwtService.IService _service;
    private readonly AppDbContext _dbContext;
    private readonly JwtOptions _jwtOption = new ();
    public Service(JwtService.IService service, AppDbContext dbContext, IConfiguration configuration)
    {//inject 3 thứ
        _service = service;//tạo token
        _dbContext = dbContext;//truy vấn db verify email/ password
        configuration.GetSection(nameof(JwtOptions)).Bind(_jwtOption);
        //bind từ file config qua cho thằng object này
    }
    public async Task<Response.IdentityResponse> Login(string email, string password)
    {
        var user = await _dbContext.Users
            .FirstOrDefaultAsync(u => u.Email == email);
        if (user == null)
        {
            throw new Exception("User not found");
        }
      
        if (user.HashedPassword != password)
        {
            throw new Exception("Invalid password");
        }
        
        //tạo claim
        var claims = new List<Claim> 
            // tạo claims: dữ liệu sẽ nằm trong payload
            //thông tin của nó được nhát vào token
        {
            new Claim("UserId", user.Id.ToString()),
            new Claim("Email", user.Email),
            new Claim("Role", user.Role),
            new Claim(ClaimTypes.Role, user.Role),
            //Phải có claim này để phân quyền cho các API endpoint, nếu thiếu claim thì sẽ ko phân quyền dược
            //Dùng cho: [Authorize(Roles = "User")]
                //Nếu thì thì Authorize sẽ không hoạt động
                //đây là role đê hệ thống hiểu mà có thể phân quyền
            new Claim(ClaimTypes.Expired,
                DateTimeOffset.UtcNow.AddMinutes(_jwtOption.ExpireMinutes).ToString()),
            //thêm custome: không cần thiết lắm
        };

        if (user.Role == "Seller")
        {
            var seller = await _dbContext.Sellers.FirstOrDefaultAsync(u => u.UserId == user.Id);
            if (seller != null)
            {
                claims.Add(new Claim("SellerId", seller.Id.ToString()));
            }
        }
        //tạo ra token với claims : claims
        //đưa thông tin user cho hệ thống tạo token
        var token = _service.GenerateAccessToken(claims);

        var result = new Response.IdentityResponse()
        {
            AccessToken = token,
        };
        //trả token ra cho người dùng
        return result;
    }
}