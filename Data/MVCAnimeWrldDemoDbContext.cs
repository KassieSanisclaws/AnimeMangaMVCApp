using AnimeMangaMVCApp.Models.AnimeList;
using Microsoft.EntityFrameworkCore;

namespace AnimeMangaMVCApp.Data
{
    public class MVCAnimeWrldDemoDbContext : DbContext
    {
        public MVCAnimeWrldDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Anime> Animes { get; set; }

    }
}
