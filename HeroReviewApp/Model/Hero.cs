namespace HeroReviewApp.Model
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ColorOfOutfit { get; set; }
        public DateTime BirthDate { get; set; }
        public bool hasSuperpowers { get; set; }
        public ComicUniverse ComicUniverse { get; set; }
        PlanetOfOrigin PlanetOfOrigin { get; set; }
        ICollection<HeroWeaknesses> Weaknesses { get; set; }
        public ICollection<SuperPower> Powers { get; set; }
        ICollection<Review> Reviews { get; set; }
    }
}
