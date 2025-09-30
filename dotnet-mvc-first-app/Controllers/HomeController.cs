using dotnet_mvc_first_app.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using dotnet_mvc_first_app.Filters;


namespace dotnet_mvc_first_app.Controllers
{
    [ServiceFilter(typeof(AuthFilter))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(user))
            {
                // Kalau belum login, redirect ke login page
                return RedirectToAction("Login", "Account");
            }

            ViewBag.Username = user;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Praktikum No 2
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
