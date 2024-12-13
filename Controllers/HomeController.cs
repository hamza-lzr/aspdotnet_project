using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projectaspdotnet.Models;

namespace projectaspdotnet.Controllers
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

        // Action method for Chapter 1
        public IActionResult Chapter1()
        {
            return View();
        }

        // Action method for Chapter 2 (if needed)
        public IActionResult Chapter2()
        {
            return View();
        }

        // Action method for Chapter 3 (if needed)
        public IActionResult Chapter3()
        {
            return View();
        }

        // Action method for Final Test (if needed)
        public IActionResult FinalTest()
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
    }
}
