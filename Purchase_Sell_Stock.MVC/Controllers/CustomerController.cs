﻿using Microsoft.AspNetCore.Mvc;
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
        [HttpPost]
        public IActionResult Allusers()
        {
            return View();
        }
        /// <summary>
        /// 全部用户功能
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="lableId"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="customerName"></param>
        /// <param name="customerPhone"></param>
        /// <param name="customerIdentity"></param>
        /// <param name="whetherEnable"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Allusers(int customerId = 1, int lableId = 1, int pageIndex = 1, int pageSize = 2, string customerName = null, string customerPhone = null, string customerIdentity = null, string whetherEnable = null)
        {
            return View();
        }
    }
}
