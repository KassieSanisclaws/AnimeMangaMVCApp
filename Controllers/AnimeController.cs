using AnimeMangaMVCApp.Data;
using AnimeMangaMVCApp.Models;
using AnimeMangaMVCApp.Models.AnimeList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeMangaMVCApp.Controllers
{
    public class AnimeController : Controller
    {
        private readonly MVCAnimeWrldDemoDbContext mvcAnimeWrldDemoDbContext;

        public AnimeController(MVCAnimeWrldDemoDbContext mvcAnimeWrldDemoDbContext)
        {
            this.mvcAnimeWrldDemoDbContext = mvcAnimeWrldDemoDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var animes = await mvcAnimeWrldDemoDbContext.Animes.ToListAsync();
            return View(animes);
        }

        [HttpGet]
        public IActionResult AddAnime()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAnime(AddAnimeViewModel addAnimeRequest)
        {
            var anime = new Anime()
            {
                Id = Guid.NewGuid(),
                Name = addAnimeRequest.Name,
                Author = addAnimeRequest.Author,
                Genre = addAnimeRequest.Genre,
                Summary = addAnimeRequest.Summary,
                NumOfArks = addAnimeRequest.NumOfArks,
                Rating = addAnimeRequest.Rating,
            };

            await mvcAnimeWrldDemoDbContext.Animes.AddAsync(anime);
            await mvcAnimeWrldDemoDbContext.SaveChangesAsync ();
            return RedirectToAction("AddAnime");
        }

        public IActionResult AnimeList()
        {
            return View();
        }
    }
}
