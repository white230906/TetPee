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
    private readonly IServiceCategory  _categoryService;
    
    public CategoryController(AppDbContext dbContext, IServiceCategory categoryService)
    {
        _dbContext = dbContext;
        _categoryService = categoryService;
    }

    [HttpGet("")]
    public async Task<IActionResult> GetCategories([FromQuery] string? searchTerm)
    {
        var categories = await _categoryService.GetCategory(searchTerm);
        return Ok(categories);
    }
    
    [HttpGet("{parentId}")]
    public async Task<IActionResult> GetCategories([FromRoute]Guid parentId)
    {
        var categoires =  await _categoryService.GetCategoryByParentId(parentId);
        return Ok(categoires);
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