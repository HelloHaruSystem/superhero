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
        public DbSet<leader> Leaders { get; set; }  
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // keeps Entity Frameworks default behavior
            base.OnModelCreating(modelBuilder);
        }
    }
}