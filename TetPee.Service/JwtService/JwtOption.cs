using System.ComponentModel.DataAnnotations;

namespace TetPee.Service.JwtService;

public class JwtOptions
{
    [Required]public string Issuer { get; set; }
    [Required]public string Audience { get; set; }
    [Required]public string SecretKey { get; set; }
    [Required]public int ExpireMinutes { get; set; }
}
//nó giống như đang làm gì đó với appsetting.json 
//Ở đoạn code đó, ta sẽ thấy đó là file config(text, Json)
//Nhưng C# không là việc được với JSon string -> cần Object
//Vậy làm biến Json thành object để C# dùng
// => Bind = map dữ liệu từ JSON vào object C#
//      đỗ dữ liệu từ file vào class