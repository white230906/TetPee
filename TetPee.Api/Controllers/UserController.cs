using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;
using TetPee.Service.User;
using IService = TetPee.Service.User.IService;

namespace TetPee.Api.Controllers;

[ApiController] 
[Route("[controller]")]// địa chỉ mà controller này lắng nghe - tạo đường dẫn URL
public class UserController: ControllerBase
{
    private readonly AppDbContext _dbContext;
    private readonly Service.MediaService.IService _meidaService;
    private readonly IService _userService;

    public UserController(AppDbContext dbContext, IService  userService,  Service.MediaService.IService meidaService)
    {
        _dbContext = dbContext;
        _userService = userService;
        _meidaService = meidaService;
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
    
    [HttpPut("{id}")]
    public IActionResult UpdateUserById(Guid id, [FromBody] Request.UpdateUserRequest request)
    {
        // var users = _dbContext.Users.ToList();
        // return Ok(users);
        return Ok("Get all users");
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteUserById(Guid id)
    {
        // var users = _dbContext.Users.ToList();
        // return Ok(users);
        return Ok("Get all users");
    }
    
    [HttpPost("")]
    public async Task<IActionResult> CreateUsers([FromForm] Request.CreateUserRequest request)
    {
        var user = new User()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            HashedPassword = request.Password // Chưa hash, chỉ demo
        };

        if (request.Avatar != null)
        {
            var media = await _meidaService.UploadImageAsync(request.Avatar);
            user.ImageUrl = media;
        }
        
        _dbContext.Add(user);
        
        await _dbContext.SaveChangesAsync();
        
        return Ok("Create user successfully");
    }
}