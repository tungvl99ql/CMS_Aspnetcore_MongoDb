using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BaseAspnetcore_mongodb
{
    public class Middleware
    {
        private readonly RequestDelegate _next;
        public Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var requestPath = httpContext.Request.Path.ToString();
            if (requestPath == "/Login/Login" || requestPath == "/Login") //  vào controller login
            {
                await _next(httpContext);
            }
            else //  controller khác
            {
                var Accounts = httpContext.Session.GetString("Account");
                var Role = httpContext.Session.GetString("Role");


                if(Role == null || Role != "100")
                {
                    await Task.Run(() =>
                           {
                               httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                               httpContext.Response.Redirect("/Login");
                           });
                    return;
                }

               await _next(httpContext);
            }
        }
    }
}
