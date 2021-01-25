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
        #region 出库
        /// <summary>
        /// 出库订单表显示
        /// </summary>
        /// <returns></returns>
        public IActionResult OutboundorderCombineShow()
        {
            return View();
        }
        /// <summary>
        /// 出库定订单详情
        /// </summary>
        /// <param name="outboundorderId"></param>
        /// <returns></returns>
        public IActionResult OutboundorderCombinebackfillPage(int outboundorderId)
        {
            ViewBag.outboundorderId = outboundorderId;
            return View();
        }

        /// <summary>
        /// 按单出库
        /// </summary>
        /// <returns></returns>
        public IActionResult PressOutboundorderCombineShow()
        {
            return View();
        }
        /// <summary>
        /// 按单出库订单页面
        /// </summary>
        /// <returns></returns>
        public IActionResult PressOutboundorderCombinebackfillPage(int outboundorderId)
        {
            ViewBag.outboundorderId = outboundorderId;
            return View();
        }
        #endregion

        #region 入库
        /// <summary>
        /// 入库订单显示
        /// </summary>
        /// <returns></returns>
        public IActionResult IncomingorderShow()
        {
            return View();
        }
        /// <summary>
        /// 入库信息详情页
        /// </summary>
        /// <param name="incomingorderid"></param>
        /// <returns></returns>
        public IActionResult IncomingordermodityDetailPage(int incomingorderid)
        {
            ViewBag.incomingorderid = incomingorderid;
            return View();
        }
        /// <summary>
        /// 按单入库订单显示
        /// </summary>
        /// <returns></returns>
        public IActionResult PressIncomingorderShow()
        {
            return View();
        }
        /// <summary>
        /// 按单入库信息详情页
        /// </summary>
        /// <param name="incomingorderid"></param>
        /// <returns></returns>
        public IActionResult PressIncomingordermodityDetailPage(int incomingorderid)
        {
            ViewBag.incomingorderid = incomingorderid;
            return View();
        }
        #endregion

        #region 商品流水 商品库存 商品差异
        /// <summary>
        /// 商品以及 商品库存
        /// </summary>
        /// <returns></returns>
        public IActionResult commodityStocksandGoodsShow()
        {
            return View();
        }
        /// <summary>
        /// 某个商品的流水
        /// </summary>
        /// <returns></returns>
        public IActionResult GoodsflowingWater(int goodsId) //传商品的编号
        {
            ViewBag.goodsId = goodsId;
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
        /// <summary>
        /// 商品差异记录
        /// </summary>
        /// <returns></returns>
        public IActionResult DifferencesShow()
        {
            return View();
        }
        #endregion

        #region 仓库
        /// <summary>
        /// 仓库显示
        /// </summary>
        /// <returns></returns>
        public IActionResult WarehouseShow()
        {
            return View();
        }
        /// <summary>
        /// 添加仓库
        /// </summary>
        /// <returns></returns>
        public IActionResult AddWarehouse()
        {
            return View();
        }
        /// <summary>
        /// 编辑仓库
        /// </summary>
        /// <returns></returns>
        public IActionResult EditWarehouse(int warehouseId)
        {
            ViewBag.warehouseId = warehouseId;
            return View();
        }
        #endregion



    }
}
