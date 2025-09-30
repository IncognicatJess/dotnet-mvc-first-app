using dotnet_mvc_first_app.Filters;
using dotnet_mvc_first_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_first_app.Controllers
{
   
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                HttpContext.Session.SetString("Username", username);

                // Redirect ke dashboard
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Username atau password salah";
            return View();
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); //Hapus semua session
            return RedirectToAction("Login", "Account");
        }
    }
}
