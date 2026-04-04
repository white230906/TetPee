using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TetPee.Service.Cart;
using TetPee.Service.Models;

namespace TetPee.Api.Controllers;
[Authorize]
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

    [HttpGet("")]
    public async Task<IActionResult> GetCart()
    {
        var cart = await _cartService.GetCart();
        return Ok(cart);
    }

    [HttpPut("")]
    public async Task<IActionResult> RemoveProductFromCart([FromBody] Request.RemoveProductFromCartRequest request)
    {
        await  _cartService.RemoveProductFromCart(request);
        return Ok(ApiResponseFactory.SuccessResponse("Successful!", "Product removed", HttpContext.TraceIdentifier));

    }
}