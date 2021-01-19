using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult ShowOrder()
        {
            return View();
        }
    }
}
