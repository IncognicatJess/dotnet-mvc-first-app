using dotnet_mvc_first_app.Filters;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_first_app.Controllers
{
    [ServiceFilter(typeof(AuthFilter))]
    public class BlogController : Controlleru                                                                                                                 
    {
        [Route("my-blog")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
