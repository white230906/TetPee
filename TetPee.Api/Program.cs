using Microsoft.EntityFrameworkCore;
using Quartz;
using TetPee.Api.Extensions;
using TetPee.Api.Middleware;
using TetPee.Repository;
using TetPee.Service.BackgroundJobService;
using TetPee.Service.Category;
using TetPee.Service.Seller;
using TetPee.Service.User;

using MailService = TetPee.Service.MailService;
using MediaService = TetPee.Service.MediaService;
using CloudinaryService = TetPee.Service.CloudinaryService;
using ProductService = TetPee.Service.Product;
using IService = TetPee.Service.User.IService;
using IdentityService = TetPee.Service.Identity;
using  JwtService = TetPee.Service.JwtService;
using  CartService = TetPee.Service.Cart;
using OrderService = TetPee.Service.Order;

//khai báo những cái đồ chơi mà mình sài
var builder = WebApplication.CreateBuilder(args);
//var builder = WebApplication.AddSwaggerGen();
// Add services to the container.

builder.Services.AddControllers();// nằm đầu tiên để kiểm soát tất cả cái đi vào
builder.Services.AddHttpContextAccessor();
/*
 * HttpContext chứa tồn bộ thông tin của request hiện tại:
 *  Users(người dùng đăng nhập)
 *  Headers
 * Cookies
 * Req/Res
 * Claims(Jwt, auth)
 */


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//kết nói xuống db
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);
//đăng kí hệ thống JWT vào .NET
    //đọc JwtOptions từ appsettings
builder.Services.AddJwtServices(builder.Configuration);
//setup Swagger để hỗ trợ JWT
    //login có token, nhưng test API trên Swagger thì ko được gửi đi
    //Swagger sẽ có nút Authorize, login thì mọi req đều có token
builder.Services.AddSwaggerServices();

builder.Services.AddScoped<OrderService.IService, OrderService.Service>();
builder.Services.AddScoped<CartService.IService, CartService.Service>();
builder.Services.AddScoped<MailService.IService, MailService.Service>();
builder.Services.AddScoped<MediaService.IService, CloudinaryService.Service>();
builder.Services.AddScoped<JwtService.IService, JwtService.Service>();
builder.Services.AddScoped<IdentityService.IService, IdentityService.Service>();
builder.Services.AddScoped<IServiceSeller, ServiceSeller>();
//thằng nào cần IServiceCategory thì inject cho tôi ServiceCategory
builder.Services.AddScoped<IServiceCategory, ServiceCategory>();
builder.Services.AddScoped<IService, Service>();
builder.Services.AddScoped<ProductService.IService, ProductService.Service>();

//Lúc nãy là có tại một class là ProcessTransactionPendingJob
    //nó đóng vai trò như một nhân viên
    //Nhưng có một vấn đề là: Ai gọi nhân viên này làm việc ? -> Quartz Scheduler
builder.Services.AddQuartz(options =>
{//tại một ID để định danh cho job này
    //Mỗi job cần có tên riêng để Scheduler quản lý 
    var jobKey = new JobKey(nameof(ProcessTransactionPendingJob));

    options
        // đăng kí job này để chạy
        .AddJob<ProcessTransactionPendingJob>(jobKey)
        //add trigger: khi nào con job này sẽ chạy
        .AddTrigger(trigger =>
            trigger
                .ForJob(jobKey)
                .WithSimpleSchedule(schedule => schedule // với lịch trình chạy là mỗi phép, time out là 2p
                    .WithIntervalInMinutes(1)
                    .RepeatForever()
                )
        );
});

builder.Services.AddQuartzHostedService(options => //Chạy Quartz như một background service trong app
//app start -> Quartz start
//app stop -> Quartz stop
{
    options.WaitForJobsToComplete = true;//nếu app tắt, hãy chờ job chạy xong rồi mới tắt
});

builder.Services.AddTransient<GlobalExceptionHandlerMiddleware>();//học

var app = builder.Build();
//sài đồ chơi nào thì bỏ dưới câu lệnh này
app.UseMiddleware<GlobalExceptionHandlerMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerAPI();
    //chỉ mở công cụ test khi đang code, không mở khi deploy
}

app.UseAuthentication();
/*
 Khi client gọi API:
Request gửi lên (có token)
UseAuthentication() sẽ:
    lấy token từ header
    kiểm tra token
    giải mã token
    Nếu hợp lệ:
    gắn user vào HttpContext
Sau đó:
[Authorize] mới hoạt động được
 */
app.UseAuthorization();

app.MapControllers();

app.Run();