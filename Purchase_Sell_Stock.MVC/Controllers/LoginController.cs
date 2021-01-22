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

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginIndex()
        {
            return View();
        }
        public ActionResult Show()
        {
            return View();
        }
        public ActionResult ForgetPwd()
        {
            return View();
        }

        public ActionResult XS(string pnoe=null)
        {
            
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

    }
}
