using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using coffee_mvc.Models;

namespace coffee_mvc.Controllers;

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



[Route ("/Menu")]
    public IActionResult  Menu  ()
    {
        return View();
    }



[Route ("/About")]
    public IActionResult  About  ()
    {
        return View();
    }


[Route ("/Blog")]
    public IActionResult  Blog  ()
    {
        return View();
    }



[Route ("/Contact")]
    public IActionResult  Contact  ()
    {
        return View();
    }

[Route ("/Services")]
    public IActionResult  Services  ()
    {
        return View();
    }


[Route ("/Shop")]
    public IActionResult  Shop  ()
    {
        return View();
    }




[Route ("/Blogsingle")]
    public IActionResult  Blogsingle  ()
    {
        return View();
    }


[Route ("/Cart")]
    public IActionResult  Cart  ()
    {
        return View();
    }


[Route ("/Checkout")]
    public IActionResult  Checkout  ()
    {
        return View();
    }




[Route ("/Productsingle")]
    public IActionResult  Productsingle ()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
