using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace VS2015Demo.Controllers
{
    public class HomeController : Controller
    {
        private int Add(int a, int b)
        {
            return a + b;
        }
        public IActionResult Index()
        {
            var c = Add(1, 2);

            List<int> elements = new List<int>() { 10, 20, 31, 40 };
            int oddIndex = elements.FindIndex(x => x % 2 != 0);

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}