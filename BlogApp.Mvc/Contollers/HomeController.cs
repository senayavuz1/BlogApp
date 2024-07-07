using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Mvc.Contollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
