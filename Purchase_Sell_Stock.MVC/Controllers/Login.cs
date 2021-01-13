using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Sell_Stock.MVC.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Show()
        {
            return View();
        }
    }
}
