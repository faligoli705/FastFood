using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Factor()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
    }
}
