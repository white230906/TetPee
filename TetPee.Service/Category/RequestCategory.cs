namespace TetPee.Service.Category;

public class RequestCategory
{
    public class CreateCategoryRequest // DTO
    {
        public required string Name { get; set; }
        public Guid? ParentId { get; set; }
    }
    
    public class UpdateCategoryRequest: CreateCategoryRequest
    {
        public Guid Id { get; set; }
    }
}