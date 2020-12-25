using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult StoreInvoicing()
        {
            return View();
        }
        public IActionResult StoreInvoicingDetails()
        {
            return View();
        }
    }
}
