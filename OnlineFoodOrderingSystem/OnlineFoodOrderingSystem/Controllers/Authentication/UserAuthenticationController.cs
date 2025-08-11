using Microsoft.AspNetCore.Mvc;

namespace OnlineFoodOrderingSystem.Controllers.Authentication
{
    public class UserAuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
