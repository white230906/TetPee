namespace TetPee.Api.Middleware;

public class GlobalExceptionHandlerMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context); // cho request đi tiếp
        }catch (Exception ex)
        { // hứng lỗi tại đây
            Console.WriteLine(ex);
        }
    }
}

// Global Exception Middleware là một cái phễu + lá chắn:
//   Mọi request đi vào → nó cho đi tiếp
// Nếu ở bất kỳ đâu phía sau (Controller / Service / Repository…) ném lỗi (throw exception)
//   nó hứng trọn
// Nó chuyển lỗi thành response chuẩn (JSON, status code)
// Server không bị crash
// Client luôn nhận response có format thống nhất