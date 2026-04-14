using TetPee.Repository.Abstraction;

namespace TetPee.Repository.Entity;

public class CartDetail: BaseEntity<Guid>, IAuditableEntity
{
    
    public int Quantity { get; set; }
    
    public Guid CartId { get; set; } // FK
    public Cart Cart { get; set; }
    public Guid ProductId { get; set; } // FK
    public Product Product { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}