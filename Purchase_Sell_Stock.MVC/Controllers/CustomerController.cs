using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Purchase_Sell_Stock.MVC.Models.CustomerFunction;


namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class CustomerController : Controller
    {
        public static string httpPart = "49.234.34.192:8022";
        /// <summary>
        /// 全部用户页面
        /// </summary>
        /// <returns></returns>
        public IActionResult Allusers()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        public IActionResult ShowGet()
        {
            ViewBag.Url = httpPart;
            return View();
        }
       /// <summary>
       /// 用户标签
       /// </summary>
       /// <returns></returns>
        public IActionResult GetLableIndex()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        /// <summary>
        /// 添加标签
        /// </summary>
        /// <returns></returns>
        public IActionResult AddLable()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        public IActionResult Modify(int Id)
        {
            ViewBag.Url = httpPart;
            ViewBag.id = Id;
            return View();
        }
        /// <summary>
        /// 充值面额
        /// </summary>
        /// <returns></returns>
        public IActionResult GetDenomination()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        /// <summary>
        /// 新建面额
        /// </summary>
        /// <returns></returns>
        public IActionResult AddDenomination()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        /// <summary>
        /// 充值记录
        /// </summary>
        /// <returns></returns>
        public IActionResult GetRechargeRecordIndex()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        /// <summary>
        /// 钱包查询
        /// </summary>
        /// <returns></returns>
        public IActionResult Getwallet()
        {
            ViewBag.Url = httpPart;
            return View();
        }
        /// <summary>
        /// 流水表
        /// </summary>
        /// <returns></returns>
        public IActionResult GetWater()
        {
            ViewBag.Url = httpPart;
            return View();
        }
    }
}
