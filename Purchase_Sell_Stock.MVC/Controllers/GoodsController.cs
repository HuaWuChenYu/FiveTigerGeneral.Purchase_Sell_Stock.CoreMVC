﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Purchase_Sell_Stock.MVC.Models.GoodsFunction;
using System.Net;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class GoodsController : Controller
    {
        public static string httpPart= "49.234.34.192:8022";
        #region 商品模块页面
        public IActionResult ShowGood()//商品页面
        {
            ViewBag.Url = httpPart;
            int StoreId = Convert.ToInt32(HttpContext.Session.GetInt32("storeId"));
            ViewBag.StoreId = StoreId;
            return View();
        }
        public IActionResult AddGood(int storeId)//添加商品页面
        {
            ViewBag.Url = httpPart;
            ViewBag.StoreId = storeId;
            return View();
        }
        public IActionResult ModifyGood(int id,int storeId)//编辑商品页面
        {
            ViewBag.Url = httpPart;
            ViewBag.StoreId = storeId;
            ViewBag.Id = id;
            return View();
        }
        public IActionResult ShowOne(int id)//明细页面
        {
            ViewBag.Url = httpPart;
            ViewBag.Id = id;
            return View();
        }
        public IActionResult Brand()//商品品牌页面
        {
            ViewBag.Url = httpPart;
            int StoreId = Convert.ToInt32(HttpContext.Session.GetInt32("storeId"));
            ViewBag.storeId = StoreId;
            return View();
        }
        public IActionResult AddBrand(int storeId)//添加品牌页面
        {
            ViewBag.Url = httpPart;
            ViewBag.storeId = storeId;
            return View();
        }
        public IActionResult Unit()//单位页面
        {
            ViewBag.Url = httpPart;
            int StoreId = Convert.ToInt32(HttpContext.Session.GetInt32("storeId"));
            ViewBag.storeId = StoreId;
            return View();
        }
        public IActionResult AddUnit(int storeId)//添加单位页面
        {
            ViewBag.Url = httpPart;
            ViewBag.storeId = storeId;
            return View();
        }
        #endregion

        //=================================================================//

        #region 商品模块功能
        [HttpPost]
        public string AddImgInMvc()//MVC添加图片供能
        {
            var s= System.Environment.CurrentDirectory;
            var uploadfile = Request.Form.Files[0];
            String name = uploadfile.FileName;//文件名称
            var path = Directory.GetCurrentDirectory();//文件夹绝对路径
            string fullPath = path + @"/wwwroot/Img/" + name;//图片绝对路径
            string filePath = @"/Img/" + name;//文件相对路径,需要保存到数据库
            using (FileStream fs = System.IO.File.Create(fullPath))
            {
                // 复制文件,保存文件至Img文件夹
                uploadfile.CopyTo(fs);
                // 清空缓冲区数据
                fs.Flush();
            }
            var dataJson = new
            {
                result = filePath,
                code = 0
            };
            return JsonConvert.SerializeObject(dataJson);
        }
        #endregion
    }
}
