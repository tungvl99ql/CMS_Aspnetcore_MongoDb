using BaseAspnetcore_mongodb.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkynetScan.Interface;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BaseAspnetcore_mongodb.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUser _Datacontext;
        public LoginController(IUser datacontext)
        {
            _Datacontext = datacontext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public Task<JsonResult> Login(string username, string password)
        {
            //_Datacontext.CreateUser(new SkynetScan.Models.UserModel { 
            //    UserName = "admin",
            //    Role = 100,
            //    DateOfBirth = DateTime.Now,
            //    Gender = 1,
            //    PassWord = "admin",
            //});

            var result = new BaseResponse<string>();
            try
            {
                if (string.IsNullOrEmpty(username.Trim()) || string.IsNullOrEmpty(password.Trim()))
                {
                    result.IsSuccess = false;
                    result.Message = "Không được để trống tên đăng nhập và mật khẩu";
                    return Task.FromResult(Json(result));
                }

               var user =  _Datacontext.CheckLogin(username, password);

                if(user != null)
                {
                    HttpContext.Session.SetString("Role", user.Role.ToString());
                    HttpContext.Session.SetString("Account", user.UserName);
                    result.IsSuccess=true;
                }

                return Task.FromResult(Json(result));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("-------------");
                result.IsSuccess = false;
                result.Message = ex.Message;
                return Task.FromResult(Json(result));
            }

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
           return RedirectToAction("Index");
        }
    }

}
