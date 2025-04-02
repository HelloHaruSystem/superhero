using Microsoft.AspNetCore.Mvc;

namespace super_hero.Controllers
{
    [Route("superheroes/[controller]")]
    [ApiController]
    public class HeroController : Controllers
    {
        private readonly SuperheroDbContext _dbContext;

        public HeroController(SuperheroDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult<Superhero>> GetHero(long id)
        {
            var hero = await _dbContext.Superheroes.FindAsync(id);

            if (hero == null)
            {
                return NotFound($"No superhero found with this {id}");
            }

            return Ok;
        }
    }  
}