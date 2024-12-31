using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using frontEnd2.Models;

namespace frontEnd2.Controllers;

public class HomeController : Controller
{
    /*
    private readonly ILogger<HomeController>? _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    IConfiguration? _configuration;

    public HomeController(IConfiguration configuration)
    {
        _configuration = configuration;
    } 
    */
    public IActionResult Index()
    {
            ViewBag.kubeEnv = Environment.GetEnvironmentVariable("KUBEENV");
            //ViewBag.myData = _configuration["Logging:myFirstValue"];
            if (ViewBag.kubeEnv == "true"){
                ViewBag.addServiceLink = "/api/Math?op=add";
                ViewBag.minusServiceLink = "/api/Math?op=minus";
                ViewBag.multiplyServiceLink = "/api/Math?op=multiply";
                ViewBag.addanddblServiceLink = "/api/Math?op=addanddbl";
               
            } else {
              //  ViewBag.addServiceLink = _configuration["Logging:addServiceLink"];
              //  ViewBag.minusServiceLink = _configuration["Logging:minusServiceLink"];
              //  ViewBag.multiplyServiceLink = _configuration["Logging:multiplyServiceLink"];
               // ViewBag.addanddblServiceLink = _configuration["Logging:addanddblServiceLink"];
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
