using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Purchase_Sell_Stock.MVC.Models.GoodsFunction;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class GoodsController : Controller
    {
        #region 商品模块页面
        public IActionResult ShowGoods()//
        {
            return View();
        }
        #endregion

        //=================================================================//

        #region 商品模块功能
        public IActionResult ShowGoods(int pageIndex, int pageSize, string goodsName, string goodsType, string goodsClassify, int storeId)
        {
            //pageIndex, pageSize, goodsName, goodsType, goodsClassify, storeId
            return View();
        }
        #endregion
    }
}
