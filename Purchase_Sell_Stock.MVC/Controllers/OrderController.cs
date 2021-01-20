using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;   

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult ShowOrder(int storeId=1)//显示订单
        {
            ViewBag.StoreId = storeId;
            return View();
        }
        public IActionResult ShowOne(int orderId)//订单明细
        {
            ViewBag.OrderId = orderId;
            return View();
        }
    }
}
