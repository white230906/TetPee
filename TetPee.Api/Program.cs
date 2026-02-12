using Microsoft.EntityFrameworkCore; //để dùng DbContext + EF Core
using TetPee.Api.Middleware; // GlobalExceptionHandlerMiddleware
using TetPee.Repository; // dùng AppDbContext
//nếu không import thì ko dùng được các class trong đó

//khai báo những cái đồ chơi mà mình sài
var builder = WebApplication.CreateBuilder(args);
// buidler = bộ công cụ để cấu hình ứng dụng trước khi chạy
//  Nó tạo ra một object giúp
//      + Đọc cấu hình (appsettings.json)
//      + Đăng kí dịch vụ (DI container)
//      + Chuẩn bị build app


// Add services to the container.

builder.Services.AddControllers();
// cho chép sử dụng Controller (API Controller)
    //Nếu không có dòng này -> Controller sẽ không hoạt động

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Dùng để tạo Swagger UI (trang test API).


//kết nói xuống db
builder.Services.AddDbContext<AppDbContext>(options => // đưang ký AppDbContext vào DI container
    options.UseNpgsql( //Dùng Dùng PostgreSQL, Npgsql là provider của PostgreSQL cho EF Core
        builder.Configuration.GetConnectionString("DefaultConnection")
    ) //lấy connection string từ appsettings.json
);
// Tóm lại nó làm đc 3 nhiệm vụ
    //EF biết kết nối DB nào
    //biết dùng server db nào
    //biết inject AppDbContext khi cần


builder.Services.AddTransient<GlobalExceptionHandlerMiddleware>();//học
// nói với DI container:
    //Mỗi lần cần GlobalExceptionHandlerMiddleware → tạo mới 1 instance.
// giống lifetime của Object:
    //Transient: Tạo mới mỗi lần
    //Scoped: 1 request dùng chung 1 instance
    //Singleton: Toàn app dùng chung 1 instance

var app = builder.Build();
//Sau khi cấu hình xong → build thành ứng dụng thật sự.

//sài đồ chơi nào thì bỏ dưới câu lệnh này
app.UseMiddleware<GlobalExceptionHandlerMiddleware>();
//request đi: Client → Middleware → Controller
//Nếu có exception → Middleware bắt lại và xử lý.


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization(); // Xác thực

app.MapControllers(); //Kích hoạt routing

app.Run(); //Chạy app

//builder.Services: Cấu hình dịch vụ
//app.Use: Cấu hình pipeline