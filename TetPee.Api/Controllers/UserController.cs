using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;
using TetPee.Service.User;

namespace TetPee.Api.Controllers;

[ApiController] 
[Route("[controller]")]// địa chỉ mà controller này lắng nghe - tạo đường dẫn URL
public class UserController: ControllerBase
{
    private readonly AppDbContext _dbContext;

    private readonly IService _userService;

    public UserController(AppDbContext dbContext, IService  userService)
    {
        _dbContext = dbContext;
        _userService = userService;
    }

    [HttpGet("")] 
    public async Task<IActionResult> GetUsers([FromQuery] string? searchTerm, int pageSize = 10, int pageIndex = 1)//bỏ vào đây ta được là sau dấu chấm hỏi
    {
        
        var users = await _userService.GetUsers(searchTerm, pageSize, pageIndex);
 
        // throw new Exception("Get Users Error");
        return Ok(users);
    }
    
    [HttpGet("{id}")] //path param: biến trên đường dẫn
    public async Task<IActionResult> GetUsers([FromRoute]Guid id) // bỏ vầo đây là ta được sau dấu / -> về test lại nha
    {
        var users = await _userService.GetUsersById(id);
        return Ok(users);
    }
    
    [HttpPost("")]
    public IActionResult CreateUsers([FromBody] Request.CreateUserRequest request)// dòng này có nghĩa là sao
    //post này tui yêu cầu bạn truyền những cái sau cho tôi
    //tại mày sài cái API này phải tryền cho t cái object có những field như thế này

    {
        var user = new User()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            HashedPassword = request.Password
        };
        
        _dbContext.Users.Add(user);// add thằng user vừa mới tạo vào bẳng User nha
        _dbContext.SaveChanges(); // hoàn tất nếu có dòng này, lưu thay đổi
         
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