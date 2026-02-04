using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;
using TetPee.Service.User;

namespace TetPee.Api.Controllers;

[ApiController] // - bật chế dộ web api
//là nhãn dán cho ASP.NET biết controller này là Web API cotroller
//Web API Controller = Controller chỉ dùng cho API, nơi nhận request
[Route("[controller]")]// địa chỉ mà controller này lắng nghe - tạo đường dẫn URL
public class UserController: ControllerBase//nơi khai báo các endpoint(URL + Method)/ API
//nó lấy được user từ việc cắt thành controller trong này ra là User ? tại sao - quy ước
//ControllerBase là class cha của tất cả web api controller
    //cung cấp sẵn cho mình các response chuẩn
{
    private readonly AppDbContext _dbContext;
    //cái này tìm hiểu sau
    //công cụ để nói chuyện với db
    //readonly: chỉ gán một lần, không đổi lung tung
    public UserController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    // HTTP Method: GET, POST, DELETE, PUT, PATCH - nói với server: tôi muốn làm gì?
    // PARAM: Query string, Path Param, Body Param - dữ liệu gửi kèm theo request
    
    
    //Query String: http://localhost:5000/User?name=abc&age=20
        // name va age là query string
        // Query string nằm sau dấu hỏi ?
    //Path(Route) Param: http://localhost:5000/User/123
        //123 là path param hoặc route param
        //ý nghĩa: tôi đang thao tác với user có id = 123
        //Path param nằm trong đường dẫn
    //Body Param: Body = dữ liệu gửi trong request, không nằm trên URL
        // {
        //     "username": "abc",
        //     "password": "123"
        // }
    
    // GET la ko có body
    // POST, PUT, PATCH có body
    
    // Tại sao phải dùng body: Tránh để lộ những thông tin ko mong muốn
    
    //ví dụ: Username, Pass
    // không thể http://localhost:5000/login?username=abc&password=123

    //Chuẩn REST FULL API
    //get all users GET http://localhost:5000/User
    //create user: POST http://localhost:5000/User
    //get user by id: GET http://localhost:5000/User/{id}
    //update user by id: PUT http://localhost:5000/User/{id}
    //delete user by id: DELETE http://localhost:5000/User/{id}
    
    // update user by id: http://localhost:5000/User/id/update - sai
    
    [HttpGet("")]
    public IActionResult GetUsers([FromQuery] string? searchTerm)//bỏ vào đây ta được là sau dấu chấm hỏi
    {
        var users = _dbContext.Users.ToList();
        return Ok(users);
    }
    
    [HttpGet("{id}")] //path param: biến trên đường dẫn
    public IActionResult GetUsers([FromRoute]Guid id) // bỏ vầo đây là ta được sau dấu / -> về test lại nha
    {
        // var users = _dbContext.Users.ToList();
        // return Ok(users);
        return Ok(id);
    }
    
    [HttpPost("")]
    public IActionResult CreateUsers([FromBody] Request.CreateUserRequest request)// dòng này có nghĩa là sao
    //post này tui yêu cầu bạn truyền những cái sau cho tôi
    //tại mày sài cái API này phải tryền cho t cái object

    {
        var user = new User()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            HashedPassword = request.Password
        };
        
        _dbContext.Users.Add(user);// à tôi mới tạo câu lệnh
        _dbContext.SaveChanges(); // mang câu lệnh xuống bd để apply
         
        Console.WriteLine(request);
        return Ok("Get all users");
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateUsers(Guid id, [FromBody] Request.UpdateUserRequest request)
    {
        // var users = _dbContext.Users.ToList();
        // return Ok(users);
        return Ok(_dbContext.Users);
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteUsers(Guid id)
    {
        // var users = _dbContext.Users.ToList();
        // return Ok(users);
        return Ok(_dbContext.Users);
    }
    
    
    
}