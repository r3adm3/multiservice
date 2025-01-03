using System.Diagnostics;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

using frontEnd2.Models;

namespace frontEnd2.Controllers;

public class HomeController : Controller
{
    private readonly IConfiguration Configuration;

    public HomeController(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IActionResult Index()
    {

            var myKey = Configuration["envValue"];

            Console.WriteLine("info: (in HomeController.cs), env key is " + myKey);
            ViewBag.kubeEnv = Environment.GetEnvironmentVariable("KUBEENV");
            //ViewBag.myData = _configuration["Logging:myFirstValue"];
            if (ViewBag.kubeEnv == "true"){
                ViewBag.addServiceLink = "/api/Math?op=add";
                ViewBag.minusServiceLink = "/api/Math?op=minus";
                ViewBag.multiplyServiceLink = "/api/Math?op=multiply";
                ViewBag.addanddblServiceLink = "/api/Math?op=addanddbl";
               
            } else {
                ViewBag.addServiceLink = Configuration["addServiceLink"];
                ViewBag.minusServiceLink = Configuration["minusServiceLink"];
                ViewBag.multiplyServiceLink = Configuration["multiplyServiceLink"];
                ViewBag.addanddblServiceLink = Configuration["addanddblServiceLink"];
            }
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
