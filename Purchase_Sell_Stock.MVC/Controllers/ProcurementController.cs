using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class ProcurementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 用于显示采购订单
        /// </summary>
        /// <returns></returns>
        public IActionResult GetProcurementsShow()
        {
            return View();
        }
        /// <summary>
        /// 用于显示商品
        /// </summary>
        /// <returns></returns>
        public IActionResult GetGoodsShow()
        {
            return View();
        }
        /// <summary>
        /// 添加采购
        /// </summary>
        /// <returns></returns>
        public IActionResult AddProcurements(string goodsid="0")
        {
            ViewBag.goodsid = goodsid;
            return View();
        }

    }
}
