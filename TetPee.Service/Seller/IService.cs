namespace TetPee.Service.Seller;

public interface IServiceSeller
{
    public Task<Base.Response.PageResult<Response.GetSellerResponse>> GetSellers(
        string? searchTerm,
        int pageSize,
        int pageIndex);
    
    public Task<Response.GetSellerResponse> GetSellersById(Guid sellerId);
}