using Microsoft.EntityFrameworkCore;
using super_hero.Models;

public class SuperheroDbContext : DbContext
{
    public SuperheroDbContext(DbContextOptions<SuperheroDbContext> options)
    : base(options)
    {
        public DbSet<PostCode> PostalCodes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Superhero> superheroes { get; set; }
        public DbSet<HeroicAct> heroicActs { get; set; }
        public DbSet<leader> leaderes { get; set; }  
    }
}