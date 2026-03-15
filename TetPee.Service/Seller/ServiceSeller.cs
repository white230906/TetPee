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
    
    public async Task<Base.Response.PageResult<ResponseSeller.GetSellerResponse>> GetSellers(string? searchTerm, int pageSize, int pageIndex)
    {//đi từ role thì nó chưa tối ưu performance vì trong user có nhiều role mà
        var query = _dbContext.Users.Where(x => x.Role == "seller");
        if (searchTerm != null)
        {
            query = query.Where(x => x.FirstName.Contains(searchTerm));
        }
        query = query.OrderBy(x => x.FirstName);
        
        query = query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize);

        var selectedQuery = query.Select(x => new ResponseSeller.GetSellerResponse()
        {
            FirstName = x.FirstName,
            LastName = x.LastName,
            Email = x.Email,
            ImageUrl = x.ImageUrl,
            TaxCode = x.Seller!.TaxCode,//à tôi biết rồi
            CompanyName = x.Seller.CompanyName,
        });

        var listResult = await selectedQuery.ToListAsync();
        var totalItems = listResult.Count;

        var result = new Base.Response.PageResult<ResponseSeller.GetSellerResponse>()
        {
            Items = listResult,
            PageIndex =  pageIndex,
            PageSize = pageSize,
            TotalItems = totalItems,
        };
        return result;

    }

    public async Task<ResponseSeller.GetSellerDetailResponse> GetSellersById(Guid sellerId)
    {
        var query = _dbContext.Users.Where(x => x.Id == sellerId 
                                                            && x.Role == "seller");
        var selectedQuery = query
            .Select(x => new ResponseSeller.GetSellerDetailResponse()
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