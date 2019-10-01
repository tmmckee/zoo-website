using Microsoft.AspNetCore.Mvc;
using ZooWebsite.Models;

namespace ZooWebsite.Controllers
{
    public class AboutZooController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutZoo()
        {
            var about = new AboutZoo
            {
                AboutZooID = 1,
                Description = "This is about the zoo!"
            };

            return View();
        }
    }
}