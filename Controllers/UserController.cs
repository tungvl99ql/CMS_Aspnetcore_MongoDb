using BaseAspnetcore_mongodb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseAspnetcore_mongodb.Controllers
{
    public class UserController : Controller
    {

        public UserController( )
        {
        }
        public IActionResult Index()
        {
            var a = HttpContext.Session.GetString("Role");
            var b = HttpContext.Session.GetString("Account");
            ViewData["Message"] = a;
            return View();
        }
    }
}
