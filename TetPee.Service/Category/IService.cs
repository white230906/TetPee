namespace TetPee.Service.Category;

public interface IServiceCategory
{
    public Task<List<Response.GetCateGoryResponse>> GetCategory(string? searchTerm);
    public Task<List<Response.GetCateGoryResponse>> GetCategoryByParentId(Guid parentId);
}