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
    
}