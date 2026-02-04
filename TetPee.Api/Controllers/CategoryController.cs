using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;
using TetPee.Service.Category;


namespace TetPee.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController: ControllerBase
{
    private readonly AppDbContext _dbContext;
    
    public CategoryController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("")]
    public IActionResult GetCategories()
    {
        var categories = _dbContext.Categories.ToList();
        return Ok(categories);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetCategories(Guid id)
    {
        // var categories = _dbContext.Categories.ToList();
        // return Ok(categories);
        return Ok(_dbContext.Categories.Find(id)); // có xử lí trường hợp null không
    }
    
    [HttpPost("")]
    public IActionResult CreateCategories([FromBody] Request.CreateCategoryRequest request)
    {
        var category = new Category()
        {
            Name = request.Name,
            ParentId  =  request.ParentId
        };

        _dbContext.Categories.Add(category);
        _dbContext.SaveChanges();

        Console.WriteLine(request);
        return Ok(category);
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateCategories(Guid id, [FromBody] Request.CreateCategoryRequest request)
    {
        // var users = _dbContext.Users.ToList();
        // return Ok(users);
        return Ok(_dbContext.Users);
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteCategories(Guid id)
    {
        // var users = _dbContext.Users.ToList();
        // return Ok(users);
        return Ok(_dbContext.Users);
    }
}