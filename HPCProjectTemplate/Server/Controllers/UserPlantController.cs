using HPCProjectTemplate.Server.Data;
using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HPCProjectTemplate.Server.Controllers
{
    public class UserPlantController : Controller
    {
        private readonly ApplicationDbContext _context;


        public UserPlantController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("api/get-plants")]
        public async Task<ActionResult<UserDTO>> GetPlants([FromQuery(Name = "userName")] string userName)
        {
            var userPlants = await _context.Users
                                   .Include(p => p.FavoritePlants)
                                   .Select(u => new UserDTO
                                   {
                                       Id = u.Id,
                                       UserName = u.UserName,
                                       //FirstName = u.FirstName,
                                       //LastName = u.LastName,
                                       FavoritePlants = u.FavoritePlants
                                   }).FirstOrDefaultAsync(u => u.UserName == userName);

            return Ok(userPlants);
        }
    }
}
