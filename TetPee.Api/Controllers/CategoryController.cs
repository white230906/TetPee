using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;
using TetPee.Service.Category;


namespace TetPee.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController: ControllerBase
{
    private readonly IServiceCategory  _categoryService;
    
    public CategoryController(IServiceCategory categoryService)
    {
        _categoryService = categoryService;
    }
    [Authorize]
    [HttpGet("")]
    public async Task<IActionResult> GetCategories(string? searchTerm)
    {
        var categories = await _categoryService.GetCategory(searchTerm);
        return Ok(categories);
    }
    
    [HttpGet("{parentId}/childrens")]
    public async Task<IActionResult> GetCategories(Guid parentId)
    {
        var categoires =  await _categoryService.GetCategoryByParentId(parentId);
        return Ok(categoires);
    }
    
}