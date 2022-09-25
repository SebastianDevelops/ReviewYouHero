namespace HeroReviewApp.Model
{
    public class PlanetOfOrigin
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Hero> Heros { get; set; }

        ICollection<PlanetOfHero> PlanetOfHero { get; set; }
    }
}
