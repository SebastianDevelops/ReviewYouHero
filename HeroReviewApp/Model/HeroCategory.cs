namespace HeroReviewApp.Model
{
    public class HeroCategory
    {
        public int HeroId { get; set; }
        public int ComicUniverseId { get; set; }
        public Hero Hero { get; set; }
        public ComicUniverse ComicUniverse { get; set; }
    }
}
