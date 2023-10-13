using HPCProjectTemplate.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HPCProjectTemplate.Server.Controllers
{
    public class PlantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlantsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("api/search-plants")]
        public async Task<IActionResult> Search(string searchString)
        {
            if (_context.PlantList is null)
            {
                return Problem("Entity set ApplicationDbContext.PlantList is null.");
            }
            var plants =  from p in _context.PlantList
                         select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                plants = plants.Where(s => s.common_name!.Contains(searchString));
            }
            return Ok(await plants.ToListAsync());
        }
    }
}
