using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyApi.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Sadece Action'a girildiğini logla
            Console.WriteLine($"Entering: {context.Request.Method} {context.Request.Path}");
            await _next(context); // Devam et
        }
    }
}
