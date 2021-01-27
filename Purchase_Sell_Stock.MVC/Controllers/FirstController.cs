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
        public IActionResult FirstPage()//首页
        {
            int StoreId = Convert.ToInt32(HttpContext.Session.GetInt32("storeId"));
            ViewBag.storeId = StoreId;
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
