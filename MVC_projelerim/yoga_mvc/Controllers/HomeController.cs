using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ödev.Models;

namespace Ödev.Controllers;

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


    [Route ("/about")]
    public IActionResult About()
    {
        return View();
    }


    [Route ("/services")]
    public IActionResult Services()
    {
        return View();
    }


    [Route ("/products")]
    public IActionResult Products()
    {
        return View();
    }

    [Route ("/rates")]
    public IActionResult Rates()
    {
        return View();
    }

     [Route ("/blog")]
    public IActionResult Blog()
    {
        return View();
    }

    [Route ("/blog/{title}/{id}")]
    public IActionResult BlogDetail(string title, int id)
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
