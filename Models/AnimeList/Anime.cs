using System.ComponentModel.DataAnnotations;

namespace AnimeMangaMVCApp.Models.AnimeList
{
    public class Anime
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Author { get; set; } = string.Empty;
        [Required]
        public string Genre { get; set; } = string.Empty;
        [Required]
        public string Summary { get; set; } = string.Empty;
        [Required]
        public int NumOfArks { get; set; }
        [Required]
        public int Rating { get; set; }

    }
}
