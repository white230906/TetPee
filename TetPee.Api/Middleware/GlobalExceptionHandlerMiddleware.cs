using TetPee.Service.Models;

namespace TetPee.Api.Middlewares;

public class GlobalExceptionHandlerMiddleware : IMiddleware
{
    private readonly IHostEnvironment _environment;
    private readonly ILogger<GlobalExceptionHandlerMiddleware> _logger;

    public GlobalExceptionHandlerMiddleware(
        IHostEnvironment environment,
        ILogger<GlobalExceptionHandlerMiddleware> logger)
    {
        _environment = environment;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled exception occurred while processing request {Path}", context.Request.Path);

            if (context.Response.HasStarted)
            {
                // Lỗi này lỗi nâng cao
                _logger.LogWarning("The response has already started, the global exception middleware will not write an error response");
                throw;
            }

            var statusCode = MapStatusCode(ex);
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/json";

            var response = ApiResponseFactory.ErrorResponse(
                message: ResolveClientMessage(ex, statusCode),
                errors: _environment.IsDevelopment() ? new { detail = ex.Message } : null,
                traceId: context.TraceIdentifier);

            await context.Response.WriteAsJsonAsync(response);
        }
    }

    private static int MapStatusCode(Exception ex)
    {
        return ex switch
        {
            ArgumentException => StatusCodes.Status400BadRequest,
            InvalidOperationException => StatusCodes.Status400BadRequest,
            UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
            KeyNotFoundException => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError
        };
    }

    private static string ResolveClientMessage(Exception ex, int statusCode)
    {
        return statusCode >= 500 ? "An unexpected error occurred" : ex.Message;
    }
}


// Global Exception Middleware là một cái phễu + lá chắn:
//   Mọi request đi vào → nó cho đi tiếp
// Nếu ở bất kỳ đâu phía sau (Controller / Service / Repository…) ném lỗi (throw exception)
//   nó hứng trọn
// Nó chuyển lỗi thành response chuẩn (JSON, status code)
// Server không bị crash
// Client luôn nhận response có format thống nhất