using Microsoft.AspNetCore.Mvc;

namespace Final.WebAppUser.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Blog");
        }
    }
}
