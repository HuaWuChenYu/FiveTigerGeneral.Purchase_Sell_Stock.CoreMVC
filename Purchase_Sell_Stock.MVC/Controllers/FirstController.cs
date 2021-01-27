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
        public IActionResult FirstPage(int storeId=1)//首页
        {
            storeId=Convert.ToInt32(HttpContext.Session.GetInt32("storeId"));
            ViewBag.StoreId = storeId;
            return View();
        }
        public IActionResult Help(int storeId)//帮助中心
        {
            ViewBag.StoreId = storeId;
            return View();
        }
        public IActionResult Message(int storeId)//消息中心
        {
            ViewBag.StoreId = storeId;
            return View();
        }
    }
}
