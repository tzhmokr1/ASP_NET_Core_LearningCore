using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Misc.Models;

namespace Misc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult JsonData()
        {
            Fruit[] fruits = new Fruit[]
            {
                new Fruit { ID = 1, Name = "Bananas", Price = 1.50M},
                new Fruit { ID = 2, Name = "Apples", Price = 1.10M},
                new Fruit { ID = 3, Name = "Oranges", Price = 1.30M},
            };

            return Json(fruits);
        }
    }
}
