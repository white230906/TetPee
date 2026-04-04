using Microsoft.AspNetCore.Mvc;
using TetPee.Service.Cart;
using TetPee.Service.Models;

namespace TetPee.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class CartController: ControllerBase
{
    private readonly IService _cartService;
    
    public CartController(IService cartService)
    {
        _cartService = cartService;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateCart()
    {
        await _cartService.CreateCart();
        return Ok(ApiResponseFactory.SuccessResponse(null, "cart created", HttpContext.TraceIdentifier));
    }

    [HttpPost("product")]
    public async Task<IActionResult> AddProductToCart([FromBody] Request.AddProductToCartRequest request)
    {
        await _cartService.AddProductToCart(request);
        return Ok(ApiResponseFactory.SuccessResponse("Successful!", "Product Add to Cart", HttpContext.TraceIdentifier));
    }
}