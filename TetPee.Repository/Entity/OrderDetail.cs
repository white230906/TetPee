using TetPee.Repository.Abstraction;

namespace TetPee.Repository.Entity;

public class OrderDetail:  BaseEntity<Guid>, IAuditableEntity
{
    public Guid OrderId { get; set; } // FK
    public Order Order { get; set; }
    
    public Guid ProductId { get; set; } // FK
    public Product Product { get; set; }
    
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }//giá tiền mua tại thời điểm đó
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}