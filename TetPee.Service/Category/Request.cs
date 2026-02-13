namespace TetPee.Service.Category;

public class Request
{
    public class CreateCategoryRequest
    {
        public required string Name { get; set; }
        public Guid? ParentId { get; set; }
    }
    
    public class UpdateCategoryRequest: CreateCategoryRequest
    {
        public Guid Id { get; set; }
    }
    
    public class DeleteCategoryRequest
    {
        public Guid Id { get; set; }
    }
    
}