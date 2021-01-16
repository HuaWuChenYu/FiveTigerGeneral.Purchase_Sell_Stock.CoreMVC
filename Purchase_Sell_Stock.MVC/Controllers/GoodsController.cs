using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Purchase_Sell_Stock.MVC.Models.GoodsFunction;
using System.Net;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;
using Newtonsoft.Json;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class GoodsController : Controller
    {
        #region 商品模块页面
        public IActionResult ShowGood()//商品页面
        {
            return View();
        }
        public IActionResult AddGood()//添加商品页面
        {
            return View();
        }
        public IActionResult AAA()
        {
            return View();
        }
        #endregion

        //=================================================================//

        #region 商品模块功能

        #endregion
    }
}
