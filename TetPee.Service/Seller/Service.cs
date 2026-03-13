using Microsoft.EntityFrameworkCore;
using TetPee.Repository;

namespace TetPee.Service.Seller;

public class ServiceSeller: IServiceSeller 
{
    private readonly AppDbContext _dbContext;
    
    public ServiceSeller(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Base.Response.PageResult<Response.GetSellerResponse>> GetSellers(string? searchTerm, int pageSize, int pageIndex)
    {
        var query = _dbContext.Users.Where(x => x.Role == "seller");
        if (searchTerm != null)
        {
            query = query.Where(x => x.FirstName.Contains(searchTerm));
        }
        query = query.OrderBy(x => x.FirstName);
        
        query = query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize);

        var selectedQuery = query.Select(x => new Response.GetSellerResponse()
        {
            Id = x.Id,
            FirstName = x.FirstName,
            LastName = x.LastName,
            Email = x.Email,
            ImageUrl = x.ImageUrl,
            TaxCode = x.Seller.TaxCode,
            CompanyName = x.Seller.CompanyName,
        });

        var listResult = await selectedQuery.ToListAsync();
        var totalItems = listResult.Count;

        var result = new Base.Response.PageResult<Response.GetSellerResponse>()
        {
            Items = listResult,
            PageIndex =  pageIndex,
            PageSize = pageSize,
            TotalItems = totalItems,
        };
        return result;

    }

    public async Task<Response.GetSellerResponse> GetSellersById(Guid sellerId)
    {
        var query = _dbContext.Users.Where(x => x.Id == sellerId && x.Role == "seller");
        var selectedQuery = query.Select(x => new Response.GetSellerResponse()
        {
            Email = x.Email,
            FirstName = x.FirstName,
            LastName = x.LastName,
            ImageUrl = x.ImageUrl,
            PhoneNumber = x.PhoneNumber,
            Address = x.Address,
            DateOfBirth =  x.DateOfBirth,
            TaxCode =  x.Seller.TaxCode,
            CompanyName = x.Seller.CompanyName,
            CompanyAddress = x.Seller.CompanyAddress,

        });

        var result = await selectedQuery.FirstOrDefaultAsync();
        return result;
    }
}