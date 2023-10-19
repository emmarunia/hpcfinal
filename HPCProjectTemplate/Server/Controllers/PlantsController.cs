using HPCProjectTemplate.Server.Data;
using HPCProjectTemplate.Shared;
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
        public async Task<IActionResult> Search(string searchString, string userName)
        {
            if (_context.PlantList is null)
            {
                return Problem("Entity set ApplicationDbContext.PlantList is null.");
            }
            if (String.IsNullOrEmpty(searchString))
            {
                return Problem("String is empty");
            }
                var userPlants = await _context.Users
                                   .Include(p => p.FavoritePlants)
                                   .Select(u => new UserDTO
                                   {
                                       Id = u.Id,
                                       UserName = u.UserName,
                                       FirstName = u.FirstName,
                                       LastName = u.LastName,
                                       FavoritePlants = u.FavoritePlants
                                   }).FirstOrDefaultAsync(u => u.UserName == userName);
            var favPlants = userPlants.FavoritePlants;
            var plants = from p in _context.PlantList
                         where p.common_name!.Contains(searchString)
                         select p;

            List<string> favPlantIds = new List<string>();
            foreach(var plant in favPlants)
            {
                favPlantIds.Add(plant.perenualId);
            }
            foreach (var plant in plants)
            {

                if(favPlantIds.Contains(plant.id.ToString())){
                    plant.isFavorite = true;
                }
            }
          
           
            return Ok(await plants.ToListAsync());
        }
        [HttpGet("api/plant-details")]
        public async Task<IActionResult> GetDetails(int plantId)
        {
            var plants = from p in _context.PlantList
                         where p.id == plantId
                         select p;
            
            return Ok(await plants.FirstOrDefaultAsync());
        }
        [HttpGet("api/get-user-plants")]
        public async Task<ActionResult<UserDTO>> GetPlants([FromQuery(Name = "userName")] string userName)
        {
            var userPlants = await _context.Users
                                   .Include(p => p.FavoritePlants)
                                   .Select(u => new UserDTO
                                   {
                                       Id = u.Id,
                                       UserName = u.UserName,
                                       FirstName = u.FirstName,
                                       LastName = u.LastName,
                                       FavoritePlants = u.FavoritePlants
                                   }).FirstOrDefaultAsync(u => u.UserName == userName);

            return Ok(userPlants);
        }
        //[HttpGet("api/add-user-plant")]
        //public async Task<ActionResult<Plant>> AddPlant(string userName, string plantId)
        //{
        //    Plant plant = new Plant { perenualId = plantId, ApplicationUserId = userName };
        //    await _context.Plants.AddAsync(plant);
        //    _context.SaveChanges();
        //    return Ok(plant);
        //}
        [HttpGet("api/add-user-plant")]
        public async Task<ActionResult> AddPlant([FromQuery(Name = "userName")] string userName, [FromQuery] string plantId)
        {
            var user = await (from u in _context.Users
                              where u.UserName == userName
                              select u).FirstOrDefaultAsync();
            Plant plant = new Plant { perenualId = plantId };

            try
            {
                user.FavoritePlants.Add(plant);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("You already have this plant in favorites!", ex);

            }


            return Ok(plant);
        }
        [HttpGet("api/remove-user-plant")]
        public async Task<ActionResult<bool>> RemovePlant([FromQuery(Name = "userName")] string userName, [FromQuery] string plantId)
        {
            var plant =  _context.Users
                                .Include(u => u.FavoritePlants)
                                .FirstOrDefault(u => u.UserName == userName)
                                .FavoritePlants.FirstOrDefault(p => p.perenualId == plantId);
            _context.Plants.Remove(plant);
            _context.SaveChanges();
            return Ok(plant);
        }

    }
}
