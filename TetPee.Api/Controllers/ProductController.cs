using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TetPee.Api.Extensions;
using TetPee.Service.Product;
using IService = TetPee.Service.Product.IService;

namespace TetPee.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class ProductController:ControllerBase
{
    private readonly IService _productService;

    public ProductController(IService productService)
    {
        _productService = productService;
    }
    [Authorize(Policy = JwtExtensions.SellerPolicy)]
    [HttpPost("CreateProduct")]
    public async Task<IActionResult> CreateProduct(Request.CreateProductRequest request)
    {
        var  result = await _productService.CreateProduct(request);
        return Ok(result);
    }
    
}