using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class ProcurementController : Controller
    {
        public static string httpPart = "49.234.34.192:8022";
        public IActionResult Index()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        /// <summary>
        /// 用于显示采购订单
        /// </summary>
        /// <returns></returns>
        public IActionResult GetProcurementsShow()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        /// <summary>
        /// 用于显示商品
        /// </summary>
        /// <returns></returns>
        public IActionResult GetGoodsShow()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        /// <summary>
        /// 添加采购
        /// </summary>
        /// <returns></returns>
        public IActionResult AddProcurements(string goodsid="0")
        {
            ViewBag.Url = httpPart;
            ViewBag.goodsid = goodsid;
            return View();
        }

    }
}
