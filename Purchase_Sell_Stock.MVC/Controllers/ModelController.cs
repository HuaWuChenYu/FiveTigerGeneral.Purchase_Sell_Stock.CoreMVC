using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Model()
        {
            return View();
        }
    }
}