namespace TetPee.Service.Seller;

public class Response
{
    public class GetSellerResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null;
        public string FirstName { get; set; }
        public string LastName { get; set; } = null;
        public string PhoneNumber { get; set; } = null;
        public string? DateOfBirth { get; set; } = null;
        public string? Address { get; set; }
        
        public string? ImageUrl { get; set; } = null;
        public string TaxCode { get; set; } = null;
        public string CompanyName { get; set; } = null;
        public string CompanyAddress { get; set; } = null;
    
    }
}
