using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Routing.Models;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Controller = "HomeController";
            ViewBag.Action = "Index";

            return View("Result");
        }

        public IActionResult Blog()
        {
            ViewBag.Controller = "HomeController";
            ViewBag.Action = "Blog";

            return View("Result");
        }

        public IActionResult ThirdSegment(string id)
        {
            ViewBag.Controller = "HomeController";
            ViewBag.Action = "ThirdSegment";

            //ViewBag.ID = RouteData.Values["id"];
            ViewBag.ID = id;

            return View("Result");
        }

        public IActionResult All(string id)
        {
            ViewBag.Controller = "HomeController";
            ViewBag.Action = "All";

            ViewBag.ID = id;
            ViewBag.All = RouteData.Values["all"];

            return View("Result");
        }

    }
}
