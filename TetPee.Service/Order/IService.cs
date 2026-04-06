namespace TetPee.Service.Order;

public interface IService
{
    public Task CreateOrder(Request.CreateOrderRequest request);
    
}