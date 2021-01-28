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
        public static string httpPart = "49.234.34.192:8022";
        RegisterHelper rh = new RegisterHelper();
        //[Route("/Login/aa")]
        //[HttpGet]
        public IActionResult Index()
        {
            ViewBag.Url = httpPart;
            return View();
            
        }
        public IActionResult Indexs(string pone = null)
        {
            ViewBag.Url = httpPart;
            int YZM = rh.Page_Load(pone);
            return View(YZM);

        }
        public IActionResult LoginIndex()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        public ActionResult Show()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        public ActionResult ForgetPwd()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        
        public ActionResult XS()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        public IActionResult Register()
        {
            ViewBag.Url = httpPart;
            return View();
        }

    }
}
