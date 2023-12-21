using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Controllers.Models;

namespace Controllers.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public IActionResult AnotherAction()
        {
            return View();
        }

        public IActionResult AnotherView()
        {
            return View("SomeView");
        }

        public IActionResult ViewWithParameter()
        {
            string SomeString = "I am a string";

            return View("ViewWithParameter", SomeString);
        }

        public IActionResult PassingData()
        {
            ViewBag.Fruit = "Apples";
            ViewData["Color"] = "Red";

            TempData["Number"] = 5;

            return View();
        }

        public IActionResult QueryString(string name, string lastname)
        {
            ViewBag.Name = name;
            ViewBag.Lastname = lastname;

            return View();
        }

        public IActionResult Redirect()
        {
            //return Redirect("http://www.google.com");
            //return RedirectToAction("PassingData");
            //return RedirectToAction("PassingData", "AnotherController");
            return RedirectToAction("PassingData", "AnotherController", new { id = 1 });
        }
    }
}
