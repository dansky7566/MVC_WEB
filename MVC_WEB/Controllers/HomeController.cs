using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_WEB.Attribute;
using MVC_WEB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MVC_WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [ExampleAttribute("dan", "001")]
        public IActionResult TestModel()
        {
            Debug.WriteLine("A");
            Thread.Sleep(5000);
            Debug.WriteLine("B");
            var testData = "Hello";
            return Json(testData);
        }
    }
}
