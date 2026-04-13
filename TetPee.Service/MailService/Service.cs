using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace TetPee.Service.MailService;

public class Service : IService
{
    private readonly MailOptions _mailOptions = new();

    //Load config mail
    public Service(IConfiguration configuration)// IConfiguration: giúp đọc file appsettings.json rồi map qua
    {
        configuration.GetSection(nameof(MailOptions)).Bind(_mailOptions);//map từ bên appsettings map qua
        //Lấy từ bên MailOptions của appsettings.json rồi map qua obecjt _mailOptins được tạo từ MailOptions
    }
    
    public async Task SendMail(MailContent mailContent) // To-Object-Body
    {
        MimeMessage email = new();// Tại email, đây là object đại diện cho email
        //người gửi
        email.Sender = new MailboxAddress(_mailOptions?.DisplayName, _mailOptions!.Mail);
        email.From.Add(new MailboxAddress(_mailOptions?.DisplayName, _mailOptions!.Mail));
        //người nhận
        email.To.Add(MailboxAddress.Parse(mailContent.To));//Parse string thành email
        //tiêu đề
        email.Subject = mailContent.Subject;
        
        //nội dung email
        BodyBuilder builder = new();
        builder.HtmlBody = mailContent.Body;    
        email.Body = builder.ToMessageBody();

        
        /*
         email = new Email()
         Không có chuyện "tạo là gửi được"
         - Mà bạn cần phải: 
            Kết nối tới server mail(Gmail, Outlook)
            Đăng nhập tài khoản
            Nhờ server đó gửi mail giúp bạn
        - Ví dụ: khi bạn muốn gửi thư bằng bưu điện
            Bạn không thể bay đi tới nhà người thân rồi đưa thư đó
            Mà bạn phải ra bưu điện - server
         */
        
        // dùng SmtpClient của MailKit
        using SmtpClient smtp = new();
        //Tạo bưu điện
        //Tạo 1 client để giao tiếp với server mail
        //using: tự đồng dọn dẹp tài nguyên sau khi dùng
        await smtp.ConnectAsync(_mailOptions?.Host, //địa chỉ server
                                _mailOptions!.Port, //cổng kết nối
                                SecureSocketOptions.StartTls);// kết nối có mã hóa
        //Kết nối tới server mail thật
        await smtp.AuthenticateAsync(_mailOptions.Mail, 
                                        _mailOptions.Password);
        //Đăng nhập tài khoảng email
        //Kiểu như: tôi là chủ tài khoảng của mail này, xin hãy cho tôi gửi thư
        await smtp.SendAsync(email);
        //Dòng này: Giúp email của mình được gửi đi
        await smtp.DisconnectAsync(true);
        //Đóng kết nối với server       
    }
}