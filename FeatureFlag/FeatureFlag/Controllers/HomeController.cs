using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FeatureFlag.Models;
using Microsoft.FeatureManagement;

namespace FeatureFlag.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IFeatureManager _featureManager;

    public HomeController(ILogger<HomeController> logger, IFeatureManager featureManager)
    {
        _logger = logger;
        _featureManager = featureManager;
    }

    public IActionResult Index()
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