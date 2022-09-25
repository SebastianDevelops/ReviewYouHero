namespace HeroReviewApp.Model
{
    public class PlanetOfHero
    {
        public int HeroId { get; set; }
        public int PlanetId { get; set; }
        public Hero Hero { get; set; }
        public PlanetOfOrigin PlanetOfOrigin { get; set; }
    }
}
