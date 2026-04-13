using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TetPee.Api.Extensions;
using TetPee.Repository;
using TetPee.Repository.Entity;
using TetPee.Service.Models;
using TetPee.Service.Seller;

namespace TetPee.Api.Controllers;

// [Authorize(Policy = JwtExtensions.AdminPolicy)]
[ApiController]
[Route("[controller]")] // địa chỉ mà controller này lắng nghe - tạo đường dẫn URL
public class SellerController : ControllerBase
{
    private readonly IServiceSeller _serviceSeller;
    public SellerController(IServiceSeller serviceSeller)
    {
        _serviceSeller = serviceSeller;
    }
    
    // [Authorize(Policy = JwtExtensions.AdminPolicy)]
    [HttpGet("")]
    public async Task<IActionResult> GetSellers([FromQuery] string? searchTerm, int pageSize = 10, int pageIndex = 1)//bỏ vào đây ta được là sau dấu chấm hỏi
    {
        
        var sellers = await _serviceSeller.GetSellers(searchTerm, pageSize, pageIndex);
 
        // throw new Exception("Get Users Error");
        return Ok(sellers);
    }
    
    [HttpGet("{sellerId}")]
    public async Task<IActionResult> GetSellersByID([FromRoute]Guid sellerId)//bỏ vào đây ta được là sau dấu chấm hỏi
    {
        
        var sellers = await _serviceSeller.GetSellersById(sellerId);
 
        // throw new Exception("Get Users Error");
        return Ok(sellers);
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateSeller(RequestSeller.CreateSellerRequest request)
    {
        var seller = await _serviceSeller.CreateSeller(request);
        return Ok(ApiResponseFactory
            .SuccessResponse(seller, "Create successfully", HttpContext.TraceIdentifier));
    }
}