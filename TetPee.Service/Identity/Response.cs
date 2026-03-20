namespace TetPee.Service.Identity;

public class Response
{
    public class IdentityResponse
    {
        public string AccessToken { get; set; } = null!;
    }
    //Đưa token về cho client sau khi login thành công
}