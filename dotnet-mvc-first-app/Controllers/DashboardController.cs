using Microsoft.AspNetCore.Mvc;
using dotnet_mvc_first_app.Filters;   // ⬅️ WAJIB supaya kenal AuthFilterAttribute

namespace dotnet_mvc_first_app.Controllers
{
    [AuthFilter]   // ini otomatis nyambung ke AuthFilterAttribute
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var username = HttpContext.Session.GetString("Username"); // ganti "User" jadi "Username"
            ViewBag.Username = username;
            return View();
        }
    }
}
