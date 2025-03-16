using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace MyApi.Authentication
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class CustomAuthAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var user = context.HttpContext.Request.Headers["Fake-User"];
            if (string.IsNullOrEmpty(user))
            {
                context.Result = new UnauthorizedResult(); // 401 Unauthorized
                return;
            }
            await next(); // Eğer doğrulama başarılıysa işlemi devam ettir
        }
    }
}
