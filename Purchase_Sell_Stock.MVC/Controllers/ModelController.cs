using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Model()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult First()
        {
            return View();
        }
    }
}