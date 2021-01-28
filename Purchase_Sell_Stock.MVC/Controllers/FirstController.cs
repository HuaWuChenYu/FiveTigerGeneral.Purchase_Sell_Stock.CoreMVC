using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class FirstController : Controller
    {
        public static string httpPart = "49.234.34.192:8022";
        public IActionResult FirstPage()//首页
        {
            ViewBag.Url = httpPart;
            int StoreId = Convert.ToInt32(HttpContext.Session.GetInt32("storeId"));
            ViewBag.storeId = StoreId;
            return View();
        }
        public IActionResult Help(int storeId)//帮助中心
        {
            ViewBag.Url = httpPart;
            ViewBag.StoreId = storeId;
            return View();
        }
        public IActionResult Message(int storeId)//消息中心
        {
            ViewBag.Url = httpPart;
            ViewBag.StoreId = storeId;
            return View();
        }
    }
}
