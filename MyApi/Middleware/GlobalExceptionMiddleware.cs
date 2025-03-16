using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace MyApi.Middleware
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext); // İşlemi gerçekleştir
            }
            catch (Exception ex)
            {
                // Global hata işleme
                Console.WriteLine($"Error: {ex.Message}");
                httpContext.Response.StatusCode = 500; // Internal Server Error
                await httpContext.Response.WriteAsync("An unexpected error occurred.");
            }
        }
    }
}
