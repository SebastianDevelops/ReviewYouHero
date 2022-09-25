namespace HeroReviewApp.Model
{
    public class ComicUniverse
    {
        public int Id { get; set; }
        public string NameOfComicUniverse { get; set; }

        public ICollection<HeroCategory> HeroCategories { get; set; }
    }
}
