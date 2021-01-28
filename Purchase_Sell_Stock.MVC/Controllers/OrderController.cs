using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;   

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class OrderController : Controller
    {
        public static string httpPart = "49.234.34.192:8022";
        public IActionResult ShowOrder()//显示订单
        {
            int StoreId = Convert.ToInt32(HttpContext.Session.GetInt32("storeId"));
            ViewBag.storeId = StoreId;
            ViewBag.Url = httpPart;
            return View();
        }
        public IActionResult ShowOne(int orderId)//订单明细
        {
            ViewBag.Url = httpPart;
            ViewBag.OrderId = orderId;
            return View();
        }
        public IActionResult CancelOrder()//退单
        {
            ViewBag.Url = httpPart;
            int StoreId = Convert.ToInt32(HttpContext.Session.GetInt32("storeId"));
            ViewBag.storeId = StoreId;
            return View();
        }
        public IActionResult CancelOrderOne(int orderId)//退单明细      
        {
            ViewBag.Url = httpPart;
            ViewBag.OrderId = orderId;
            return View();
        }
        public IActionResult Comment()//评论页面 
        {
            ViewBag.Url = httpPart;
            int StoreId = Convert.ToInt32(HttpContext.Session.GetInt32("storeId"));
            ViewBag.storeId = StoreId;
            return View();
        }
        public IActionResult LookReply(int commentId)//回复页面 
        {
            ViewBag.Url = httpPart;
            ViewBag.CommentId = commentId;
            return View();
        }

    }
}
