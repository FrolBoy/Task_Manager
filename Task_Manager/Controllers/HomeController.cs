using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Task_Manager.Models;

namespace Task_Manager.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
}

   