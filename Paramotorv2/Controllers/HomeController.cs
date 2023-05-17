using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using occupy.Models;
using occupy.Models.Entities;

namespace occupy.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    ParamatordbContext db = new ParamatordbContext();

    public IActionResult Index()
    {
        var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);
    }

    [Route("/about-us")]
      public IActionResult AboutUs()
    {
        var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);
    }
    [Route("/service")]
    public IActionResult Service()
    {var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);

    }

    [Route("/event")]
    public IActionResult Event()
    {
        {var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);

    }

    }

[Route("/blog")]
    public IActionResult Blog()
    {var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);

    }





[Route("/course")]
    public IActionResult Course()
    {var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);

    }
    [Route("/CourseDetail")]
    public IActionResult CourseDetail()
    {var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);

    }






[Route("/blog-detail/{title}/{id}")]
    public IActionResult BlogDetail(string title, int id)
    {var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);

    }

    [Route("/contact")]
    public IActionResult Contact()
     {
        var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
