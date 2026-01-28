namespace TetPee.Repository.Abstraction;

public abstract class BaseEntity<Tkey>//thành ngữ Generit
{
    public required Tkey Id { get; set; }
    
    public bool IsDeleted  { get; set; }
}