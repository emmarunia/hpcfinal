using HPCProjectTemplate.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HPCProjectTemplate.Server.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("api/products")]
        public async Task<IActionResult> GetProducts()
        {
            if (_context.Products is null)
            {
                return Problem("Entity set ApplicationDbContext.Products is null.");
            }
            var products = from p in _context.Products
                           select p;

            return Ok(await products.ToListAsync());
        }
    }
}
