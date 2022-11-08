using Microsoft.AspNetCore.Mvc;

namespace AnimeMangaMVCApp.Controllers
{
    public class AnimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AnimeList()
        {
            return View();
        }
    }
}
