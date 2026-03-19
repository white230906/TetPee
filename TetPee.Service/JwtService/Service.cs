using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace TetPee.Service.JwtService;

public class Service: IService
{
    private readonly JwtOptions _jwtOption = new();

    public Service(IConfiguration configuration)
    {
        configuration.GetSection(nameof(JwtOptions)).Bind(_jwtOption);
        //Anh xa duw tu tu AppSettings vao object JwtOptions
    }
    public string GenerateAccessToken(IEnumerable<Claim> claims)
    {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOption.SecretKey));
       //tạo 1 Key để mã hóa token, sử dụng secretKey từ JwtOptions
        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        //Tạo 1 đối tượng SigningCredentials để xác định thuật toán mã hóa và key sử dụng để ký token
        
        var tokenOptions = new JwtSecurityToken(
            issuer: _jwtOption.Issuer, //Cái token này được kí - tạo bởi ai, tổ chức nào 
            audience: _jwtOption.Audience, // Cái token này dành cho ai, tổ chức nào
            claims: claims, // Những thông tin mà bạn muốn lưu trữ trong token,
                        // thường là thông tin về người dùng như Id, email, role, ..
                        // nằm trong payload
            expires: DateTime.Now.AddMinutes(_jwtOption.ExpireMinutes),//Token sẽ hết hạn sau bao lâu
            signingCredentials: signingCredentials
        );
        
        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        //Sau đó JwtSercurityTokenHandler
            // để tạo ra token dưới dạng chuỗi(string) từ các thông tin đã cung cấp ở trên
        return tokenString;
    }

    public ClaimsPrincipal ValidateToken(string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_jwtOption.SecretKey); // Sử dụng _jwtOption 

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = true,
                ValidIssuer = _jwtOption.Issuer,
                ValidateAudience = true,
                ValidAudience = _jwtOption.Audience,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };

            var principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
            return principal;
        }
        catch (SecurityTokenException ex)
        {
            Console.WriteLine($"Token validation failed: {ex.Message}");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error during token validation: {ex.Message}");
            return null;
        }
    }
}
//claims