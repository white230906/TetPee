namespace TetPee.Service.User;

public class Request// gọi là DTO(Data Transfer Object): là gì ?
    //là object chỉ dùng để chứa properties, ko chứa logic xử lý
    //nó tồn tại để truyền dữ liệu giữa các layer
    /*
     * Client gửi JSON
    Controller nhận JSON
    Map JSON → Request DTO
    Service dùng DTO để xử lý
     */
{
    public class CreateUserRequest //DTO
    {
        public required string Email {get; set;}
        public required string FirstName {get; set;}
        public required string LastName {get; set;}
        public required string Password {get; set;}
    }
//     Ý nghĩa:
// Đây là dữ liệu cần thiết để tạo user
// Chỉ chứa những field được phép nhập từ client
// Vì sao không dùng User entity luôn?
// Tránh client set bậy IsDeleted
// Tránh client set Role    
// Tránh client set Id
// ➡️ Bảo vệ domain
    
    public class UpdateUserRequest: CreateUserRequest
    {   
        public Guid Id  {get; set;}
    }
}