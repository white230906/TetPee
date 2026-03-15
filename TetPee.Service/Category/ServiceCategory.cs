using Microsoft.EntityFrameworkCore;
using TetPee.Repository;

namespace TetPee.Service.Category;

public class ServiceCategory: IServiceCategory
{
    private readonly AppDbContext _dbcontext;
//ko inject DB
    public ServiceCategory(AppDbContext dbContext)
    {
        _dbcontext = dbContext;
    }
    
    public async Task<List<ResponseCategory.GetCateGoryResponse>> GetCategory(string? searchTerm)
    {
        var query = _dbcontext.Categories.Where(x => true);
        if (searchTerm != null)
        {
            query = query.Where(x => x.Name.Contains(searchTerm));
        }
        
        query = query.OrderBy(x => x.Name);
        
        var selectedQuery = query.Select(x => new ResponseCategory.GetCateGoryResponse()
        {
            Id = x.Id,
            Name = x.Name,
        });

        var result = await selectedQuery.ToListAsync();
        return result;
    }

    public async Task<List<ResponseCategory.GetCateGoryResponse>> GetCategoryByParentId(Guid parentId)
    {
        var query = _dbcontext.Categories.Where(x => x.ParentId == parentId);
        query = query.OrderBy(x => x.Name);
        var selectedQuery = query.Select(x => new ResponseCategory.GetCateGoryResponse()
        {
            Id = x.Id,
            Name = x.Name,
            ParentId =  x.ParentId,
        });

        var result = await selectedQuery.ToListAsync();
        return result;
    }
}