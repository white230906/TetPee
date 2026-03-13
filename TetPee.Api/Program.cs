using Microsoft.EntityFrameworkCore;
using TetPee.Api.Middleware;
using TetPee.Repository;
using TetPee.Service.Category;
using TetPee.Service.Seller;
using TetPee.Service.User;
using IService = TetPee.Service.User.IService;

//khai báo những cái đồ chơi mà mình sài
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();// nằm đầu tiên để kiểm soát tất cả cái đi vào
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//kết nói xuống db
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddScoped<IServiceSeller, ServiceSeller>();
//thằng nào cần IServiceCategory thì inject cho tôi ServiceCategory
builder.Services.AddScoped<IServiceCategory, ServiceCategory>();
builder.Services.AddScoped<IService, Service>();
builder.Services.AddTransient<GlobalExceptionHandlerMiddleware>();//học


var app = builder.Build();
//sài đồ chơi nào thì bỏ dưới câu lệnh này
app.UseMiddleware<GlobalExceptionHandlerMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();