namespace HeroReviewApp.Model
{
    public class PlanetsSavedByHero
    {
        public int HeroId { get; set; }
        public int PlanetId { get; set; }
        public Hero Hero { get; set; }
        public PlanetsSaved PlanetOfOrigin { get; set; }
    }
}
