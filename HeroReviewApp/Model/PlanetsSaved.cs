namespace HeroReviewApp.Model
{
    public class PlanetsSaved
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Hero> Heros { get; set; }

        ICollection<PlanetsSavedByHero> PlanetsSavedByHero { get; set; }
    }
}
