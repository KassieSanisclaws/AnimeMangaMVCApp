namespace AnimeMangaMVCApp.Models.AnimeList
{
    public class Anime
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Summary { get; set; }
        public int NumOfArks { get; set; }
        public int Rating { get; set; }

    }
}
