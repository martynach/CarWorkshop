using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarWorkshop.Models;

namespace CarWorkshop.Controllers;

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
    
    public IActionResult Exercise()
    {
        // var message = "some message";
        // return View(message);

        var myNumber = 55;
        return View(myNumber);

    }
    
    public IActionResult About()
    {
        var about = new AboutViewModel()
        {
            Title = "M&T car workshop SUPER",
            Description = "Best car workshop in the whole city",
            Tags = new String[] { "cars", "ford", "mercedes", "workshop" }
        };
        return View(about);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
