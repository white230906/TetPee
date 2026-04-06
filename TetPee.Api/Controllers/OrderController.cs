using Microsoft.AspNetCore.Mvc;
using TetPee.Repository.Entity;
using TetPee.Service.Order;

namespace TetPee.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class OrderController: ControllerBase
{
    private readonly IService _orderService;
    public OrderController(IService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateOrder(Request.CreateOrderRequest createOrderRequest)
    {
        return Ok("");
    }
}