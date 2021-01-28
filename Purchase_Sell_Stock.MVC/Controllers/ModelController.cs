using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class ModelController : Controller
    {
        public static string httpPart = "49.234.34.192:8022";
        public IActionResult Model(int eid=1,int sid=1)
        {
            ViewBag.id = eid;
            HttpContext.Session.SetInt32("storeId",sid);
            ViewBag.Url = httpPart;
            ViewBag.sid = sid;
            return View();
        }
        public IActionResult CreateStore(int id=1)
        {
            ViewBag.empid = id;
            ViewBag.Url = httpPart;
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Test2()
        {
            return View();
        }
        public IActionResult First()
        {
            return View();
        }
        public IActionResult ChoseStore(string phone="12345678999")
        {
            ViewBag.Url = httpPart;
            ViewBag.phone = phone;
            return View();
        }
    }
}