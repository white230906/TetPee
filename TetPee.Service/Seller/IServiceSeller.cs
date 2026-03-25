namespace TetPee.Service.Seller;

public interface IServiceSeller
{
    public Task<Base.Response.PageResult<ResponseSeller.GetSellerResponse>> GetSellers(
        string? searchTerm,
        int pageSize,
        int pageIndex);
    
    public Task<ResponseSeller.GetSellerDetailResponse> GetSellersById(Guid sellerId);
    
    public Task<string> CreateSeller(RequestSeller.CreateSellerRequest request);
}