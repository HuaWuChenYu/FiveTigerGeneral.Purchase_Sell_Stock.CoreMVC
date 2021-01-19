using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Purchase_Sell_Stock.MVC.Models.LoginFunction;
using System.Text;
using System.Net;
using System.IO;
using System.Configuration;
using Microsoft.AspNetCore.Http;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class LoginController : Controller
    {
        RegisterHelper rh = new RegisterHelper();
        [Route("/Login/index")]
        public IActionResult Index()
        {
            
            return View();
        }
        public static string PostUrl = ConfigurationManager.AppSettings["WebReference.Service.PostUrl"];
        public IActionResult LoginIndex()
        {
            return View();
        }
       [Route("/Login/Show")]
        public ActionResult Show()
        {
            return View();
        }
        [Route("/Login/ForgetPwd")]
        public ActionResult ForgetPwd()
        {
            return View();
        }
        public ActionResult XS()
        {
            return View();
        }

    }
}
