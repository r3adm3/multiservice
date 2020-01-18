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
            //Console.WriteLine(" ** " + _configuration["Logging:addServiceLink"]);
            ViewBag.kubeEnv = Environment.GetEnvironmentVariable("KUBEENV");
            ViewBag.myData = _configuration["Logging:myFirstValue"];
            if (ViewBag.kubeEnv == "true"){
                ViewBag.addServiceLink = "http://myservice-as.default.svc.cluster.local/api/Math&op=add";
                ViewBag.minusServiceLink = "http://myservice-mis.default.svc.cluster.local/api/Math&op=minus";
                ViewBag.multiplyServiceLink = "http://myservice-mxs.default.svc.cluster.local/api/Math&op=multiply";
               
            } else {
                ViewBag.addServiceLink = _configuration["Logging:addServiceLink"];
                ViewBag.minusServiceLink = _configuration["Logging:minusServiceLink"];
                ViewBag.multiplyServiceLink = _configuration["Logging:multiplyServiceLink"];
            }
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
