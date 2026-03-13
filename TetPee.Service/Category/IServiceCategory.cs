namespace TetPee.Service.Category;

public interface IServiceCategory
{
    public Task<List<ResponseCategory.GetCateGoryResponse>> GetCategory(string? searchTerm);
    public Task<List<ResponseCategory.GetCateGoryResponse>> GetCategoryByParentId(Guid parentId);
}