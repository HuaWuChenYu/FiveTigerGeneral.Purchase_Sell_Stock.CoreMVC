using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Purchase_Sell_Stock.MVC.Models.Stroage;
using Purchase_Sell_Stock.MVC.Models.ProcurementFunction;
using Purchase_Sell_Stock.MVC.Models.OrderFunction;
using Purchase_Sell_Stock.MVC.Models.GoodsFunction;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class StroageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 入库订单表显示
        /// </summary>
        /// <returns></returns>
        public IActionResult OutboundorderCombineShow()
        {
            return View();
        }
        /// <summary>
        /// 入库订单详情
        /// </summary>
        /// <returns></returns>
        public IActionResult OutboundorderCombinebackfillPage(int outboundorderId)
        {
            ViewBag.outboundorderId = outboundorderId;
            return View();
        }
        /// <summary>
        /// 商品以及 商品库存
        /// </summary>
        /// <returns></returns>
        public IActionResult commodityStocksandGoodsShow()
        {
            return View();
        }
        /// <summary>
        /// 流水记录表
        /// </summary>
        /// <returns></returns>
        public IActionResult goodRunningWaterShow()
        {
            return View();
        }

    }
}
