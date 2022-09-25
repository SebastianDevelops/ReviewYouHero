using Microsoft.EntityFrameworkCore;
using HeroReviewApp.Model;

namespace HeroReviewApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {  }
        public DbSet<ComicUniverse> ComicUniverses { get; set; }
        public DbSet<Hero> Heros { get; set; }
        public DbSet<HeroCategory> HeroCategories {  get; set; }
        public DbSet<PlanetsSavedByHero> planetOfHeroes { get; set; }
        public DbSet<PlanetsSaved> planetOfOrigins { get; set; }
        public DbSet<Review> reviews {  get; set; }
        public DbSet<Reviewer> reviewers { get; set; }
        public DbSet<SuperPower> superPowers { get; set; }
        public DbSet<HeroWeaknesses> heroWeaknesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlanetsSavedByHero>()
                .HasKey(pk => new { pk.HeroId, pk.PlanetId });

            modelBuilder.Entity<PlanetsSavedByHero>()
                .HasOne(h => h.Hero)
                .WithMany(p => p.PlanetsSaved);

            modelBuilder.Entity<PlanetsSavedByHero>()
                .HasKey(pk => new { pk.HeroId, pk.PlanetId });
        }
    }
}
