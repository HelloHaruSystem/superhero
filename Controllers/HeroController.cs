using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using super_hero.Data;
using super_hero.Models;

namespace super_hero.Controllers
{
    [Route("superheroes/")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly SuperheroDbContext _dbContext;

        public HeroController(SuperheroDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Superhero>> GetHero(long id)
        {
            var hero = await _dbContext.Superheroes.FindAsync(id);

            if (hero == null)
            {
                return NotFound($"No superhero found with ID {id}");
            }

            return Ok(hero);
        }

        [HttpGet("postcode")]
        public async Task<ActionResult<PostCode>> GetPostCode()
        {
            List<PostCode> PostCodes = await _dbContext.PostalCodes.ToListAsync();

            if (PostCodes == null)
            {
                return NotFound($"No Postal codes found");
            }

            return Ok(PostCodes);
        }
    }  
}