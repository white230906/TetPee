namespace TetPee.Service.Identity;

public interface IService
{
    public Task<Response.IdentityResponse> Login(string email, string password);
}
//Nhiệm vụ của Identity:
//Kiểm tra email/password
//Nếu đúng -> xác nhận user
//Tạo token (gọi jwtService)
//Trả token về cho client