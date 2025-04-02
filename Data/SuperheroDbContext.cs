using Microsoft.EntityFrameworkCore;
using super_hero.Models;

namespace super_hero.Data
{
    public class SuperheroDbContext : DbContext
    {
        public SuperheroDbContext(DbContextOptions<SuperheroDbContext> options)
        : base(options)
        {

        }

        public DbSet<PostCode> PostalCodes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Superhero> Superheroes { get; set; }
        public DbSet<HeroicAct> HeroicActs { get; set; }
        public DbSet<Leader> Leaders { get; set; }  
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostCode>()
                .ToTable("postal_codes")
                .Property(p => p.PostalCode)
                .HasColumnName("postal_code");
            
            modelBuilder.Entity<PostCode>()
                .Property(p => p.CityName)
                .HasColumnName("city_name");

            base.OnModelCreating(modelBuilder);
        }
    }
}