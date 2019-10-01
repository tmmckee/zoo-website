using Microsoft.AspNetCore.Mvc;
using ZooWebsite.Models;
using ZooWebsite.ZooContext;

namespace ZooWebsite.Controllers
{
    public class AnimalsController : Controller
    {

        private readonly EFDataContext _db;

        public AnimalsController(EFDataContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Animals animal)
        {
            if (!ModelState.IsValid)
                return View();

            _db.Animals.Add(animal);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}