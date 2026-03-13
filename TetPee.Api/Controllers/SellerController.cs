using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Service.Seller;

namespace TetPee.Api.Controllers;

[ApiController]
[Route("[controller]")] // địa chỉ mà controller này lắng nghe - tạo đường dẫn URL
public class SellerController : ControllerBase
{
    private readonly AppDbContext _dbContext;
    private readonly IServiceSeller _serviceSeller;

    public SellerController(AppDbContext dbContext, IServiceSeller serviceSeller)
    {
        _dbContext = dbContext;
        _serviceSeller = serviceSeller;
    }
    
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
}