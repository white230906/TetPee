using System.Security.Claims;

namespace TetPee.Service.JwtService;

public interface IService
{
    //tạo token đưa về cho client
    public string GenerateAccessToken(IEnumerable<Claim> claims);
    //khi client gọi API
    //kiểm tra token có hợp lệ không
    ClaimsPrincipal ValidateToken(string token);
}