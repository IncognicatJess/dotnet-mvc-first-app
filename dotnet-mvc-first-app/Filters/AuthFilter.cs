using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace dotnet_mvc_first_app.Filters
{
    // Attribute biar bisa dipasang di controller: [AuthFilter]
    public class AuthFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var session = context.HttpContext.Session.GetString("User");

            if (string.IsNullOrEmpty(session))
            {
                context.Result = new RedirectToActionResult("Login", "Account", null);
            }
        }
    }
}
