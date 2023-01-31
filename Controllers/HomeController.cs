using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SkynetScan.Interface;
using SkynetScan.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Nethereum.Web3;
using System.Numerics;
using BaseAspnetcore_mongodb;
using Microsoft.AspNetCore.Http;

namespace SkynetScan.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IUser _Datacontext;
       

        public HomeController(IUser datacontext)
        {
            _Datacontext = datacontext;
        }

        public IActionResult Index()
        {
            //HttpContext.Session.SetString("Role", "The Doctor");
            //HttpContext.Session.SetString("Account", "The Doctor");
            return View();
        }


        [HttpPost]
        public async Task<string> AddItems(string datajson)
        {
            return "ok";
        }

    }
}
