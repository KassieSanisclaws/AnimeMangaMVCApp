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
        
        /*Return Anime List from Database of the Anime within DB. View is set as table styling using boot-strap. WORKING*/
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var animes = await mvcAnimeWrldDemoDbContext.Animes.ToListAsync();
            return View(animes);
        }

        /*ADD Anime View form and redirect user to index page. WORKING*/
        [HttpGet]
        public IActionResult AddAnime()
        {
            return View();
        }

        /*ADD New Anime View model which is a form that submits the additon to the Database and updates DB with result. WORKING*/
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
                Rating = addAnimeRequest.Rating
            };

            await mvcAnimeWrldDemoDbContext.Animes.AddAsync(anime);
            await mvcAnimeWrldDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        /*This Views the selected Anime from Database and Returns view with form to update that selected Anime. WORKING*/
        [HttpGet]
        public async Task<IActionResult> View(Guid? Id)
        {
            var anime = await mvcAnimeWrldDemoDbContext.Animes.FirstOrDefaultAsync(x => x.Id == Id);
            if(anime != null)
            {
              var viewModel = new UpdateAnimeViewModel()
            {
                Id = anime.Id,
                Name = anime.Name,
                Author = anime.Author,
                Genre = anime.Genre,
                Summary = anime.Summary,
                NumOfArks = anime.NumOfArks,
                Rating = anime.Rating
            };
                return await Task.Run(() => View("View", viewModel));
            }     
            return RedirectToAction("Index");       
        }

        /*UPDATE Anime from database IAction Request updating the databse and return user to the view of anime list refelcted from DB.WORKING*/
        [HttpPost]
        public async Task<IActionResult> View(UpdateAnimeViewModel model)
        {
            var anime = await mvcAnimeWrldDemoDbContext.Animes.FindAsync(model.Id);
            if(anime != null)
            {
                anime.Name = model.Name;
                anime.Author = model.Author;
                anime.Genre = model.Genre;
                anime.Summary = model.Summary;
                anime.NumOfArks = model.NumOfArks;
                anime.Rating = model.Rating;

                await mvcAnimeWrldDemoDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            /*TODO: the below should send user to anime not found page 404 redirect if anime does not match or is not found in database.*/
                return RedirectToAction("Index");
        }

        /*DELETE Method  for deleting record of anime TODO: create button within View.cshtml*/
        [HttpPost]
        public async Task<IActionResult> Delete(UpdateAnimeViewModel model)
        {
            var anime = await mvcAnimeWrldDemoDbContext.Animes.FindAsync(model.Id);

            if(anime != null)
            {
                mvcAnimeWrldDemoDbContext.Animes.Remove(anime);
                await mvcAnimeWrldDemoDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            /*TODO If Anime not found redirect user to 404 Page not found. Redirect to Index Page Current.*/
                return RedirectToAction("Index");
        }

        public IActionResult AnimeList()
        {
            return View();
        }
    }
}
