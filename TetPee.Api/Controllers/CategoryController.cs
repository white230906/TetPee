using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;
using TetPee.Service.Category;
using TetPee.Service.Models;


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
        var result = await _categoryService.GetCategory(searchTerm);
        return Ok(ApiResponseFactory
            .SuccessResponse(result, "Categories retrieved", HttpContext.TraceIdentifier));
    }
    
    [HttpGet("{parentId}/children")]
    public async Task<IActionResult> GetCategories(Guid parentId)
    {
        var categoires =  await _categoryService.GetCategoryByParentId(parentId);
        return Ok(categoires);
    }
    
}