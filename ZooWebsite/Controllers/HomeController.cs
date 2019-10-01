using Microsoft.AspNetCore.Mvc;

namespace ZooWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}