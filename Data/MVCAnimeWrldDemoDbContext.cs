using AnimeMangaMVCApp.Models.AnimeList;
using Microsoft.EntityFrameworkCore;

namespace AnimeMangaMVCApp.Data
{
    public class MVCAnimeWrldDemoDbContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public MVCAnimeWrldDemoDbContext(DbContextOptions options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        public DbSet<Anime> Animes { get; set; } 

    }
}
