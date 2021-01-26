﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Model(int eid=1,int sid=1)
        {
            ViewBag.id = eid;
            HttpContext.Session.SetInt32("storeId",sid);
            ViewBag.sid = sid;
            return View();
        }
        public IActionResult CreateStore(int id=1)
        {
            ViewBag.empid = id;
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Test2()
        {
            return View();
        }
        public IActionResult First()
        {
            return View();
        }
        public IActionResult ChoseStore(string phone="18312345671")
        {
            ViewBag.phone = phone;
            return View();
        }
    }
}