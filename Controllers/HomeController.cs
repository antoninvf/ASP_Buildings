using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASP_Buildings.Models;

namespace ASP_Buildings.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}