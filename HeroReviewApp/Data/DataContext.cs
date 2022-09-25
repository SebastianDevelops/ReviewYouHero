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
        public DbSet<PlanetOfHero> planetOfHeroes { get; set; }
        public DbSet<PlanetOfOrigin> planetOfOrigins { get; set; }
        public DbSet<Review> reviews {  get; set; }
        public DbSet<Reviewer> reviewers { get; set; }
        public DbSet<SuperPower> superPowers { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroCategory>()
                .HasKey(pk => new { pk.HeroId, pk.ComicUniverseId });
        }
    }
}
