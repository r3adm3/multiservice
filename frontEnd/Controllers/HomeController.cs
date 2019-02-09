using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using frontEnd.Models;
using Microsoft.Extensions.Configuration; 

namespace frontEnd.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        } 

        public IActionResult Index()
        {
            ViewBag.myData = _configuration["myFirstValue"];
            ViewBag.addServiceLink = _configuration["addServiceLink"];
            ViewBag.minusServiceLink = _configuration["minusServiceLink"];
            ViewBag.multiplyServiceLink = _configuration["multiplyServiceLink"];
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
