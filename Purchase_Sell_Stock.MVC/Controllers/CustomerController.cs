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
        /// <summary>
        /// 全部用户页面
        /// </summary>
        /// <returns></returns>
        public IActionResult Allusers()
        {
            return View();
        }
        public IActionResult ShowGet()
        {
            return View();
        }
       /// <summary>
       /// 用户标签
       /// </summary>
       /// <returns></returns>
        public IActionResult GetLableIndex()
        {
            return View();
        }
        /// <summary>
        /// 添加标签
        /// </summary>
        /// <returns></returns>
        public IActionResult AddLable()
        {
            return View();
        }
        public IActionResult Modify(int Id)
        {
            ViewBag.id = Id;
            return View();
        }
        /// <summary>
        /// 充值面额
        /// </summary>
        /// <returns></returns>
        public IActionResult GetDenomination()
        {
            return View();
        }
        /// <summary>
        /// 新建面额
        /// </summary>
        /// <returns></returns>
        public IActionResult AddDenomination()
        {
            return View();
        }
        /// <summary>
        /// 充值记录
        /// </summary>
        /// <returns></returns>
        public IActionResult GetRechargeRecordIndex()
        {
            return View();
        }
        /// <summary>
        /// 钱包查询
        /// </summary>
        /// <returns></returns>
        public IActionResult Getwallet()
        {
            return View();
        }
        /// <summary>
        /// 流水表
        /// </summary>
        /// <returns></returns>
        public IActionResult GetWater()
        {
            return View();
        }
    }
}
