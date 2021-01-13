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
        [HttpPost]
        public IActionResult ShowGood()//商品页面
        {
            return View();
        }
        #endregion

        //=================================================================//
        [HttpGet]
        #region 商品模块功能
        public IActionResult ShowGood(int pageIndex=1, int pageSize=2, string goodsName=null, string goodsType = null, string goodsClassify = null, int storeId=1)
        {
            string url = "http://localhost:49760/api/GetGoodsList" + $"/{ pageIndex}/{ pageSize}/{ goodsName}/{ goodsType}/{ goodsClassify}/{ storeId}";
            var by = new WebClient().DownloadData(url);
            var result2 = System.Text.Encoding.UTF8.GetString(by);
            GoodsPaging<Goods> ss = JsonConvert.DeserializeObject<GoodsPaging<Goods>>(result2);//把json转成对象
            //pageIndex, pageSize, goodsName, goodsType, goodsClassify, storeId
            return View();
        }
        #endregion
    }
}
