using Microsoft.AspNetCore.Mvc;
using super_hero.Data;

namespace super_hero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly SuperheroDbContext _context;

        public TestController(SuperheroDbContext context)
        {
            _context = context;
        }

        [HttpGet("test-db")]
        public IActionResult TestDatabase(){
            try
            {
                _context.Database.CanConnect();
                return Ok("Database connection is successful! :)");
            } catch (Exception e) {
                return StatusCode(500, $"Database connection failed: {e.Message}");
            }
        }
    }
}