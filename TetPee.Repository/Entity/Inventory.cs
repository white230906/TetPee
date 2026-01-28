using TetPee.Repository.Abstraction;

namespace TetPee.Repository.Entity;

public class Inventory: BaseEntity<Guid>, IAuditableEntity
{
    
    public Guid  ProductId { get; set; }
    public Product Product  { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}