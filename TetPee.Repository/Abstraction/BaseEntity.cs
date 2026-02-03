namespace TetPee.Repository.Abstraction;

public abstract class BaseEntity<Tkey>//thành ngữ Generit
{
    public Tkey Id { get; set; }
    
    public bool IsDeleted  { get; set; }
}