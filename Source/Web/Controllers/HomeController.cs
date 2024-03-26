using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shopopolis.Source.Core.Models;

namespace Shopopolis.Source.Web.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        ViewBag.CurrentYear = DateTime.Now.Year;

        return View();
    }

    public IActionResult Privacy()
    {
        ViewBag.CurrentYear = DateTime.Now.Year;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        ViewBag.CurrentYear = DateTime.Now.Year;

        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
