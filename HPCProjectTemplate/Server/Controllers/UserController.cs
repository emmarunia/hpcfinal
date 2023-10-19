using HPCProjectTemplate.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HPCProjectTemplate.Server.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("api/personal")]
        public async Task<IActionResult> GetPersonalDetails(string UserName)
        {
            var user = from u in _context.Users
                       where u.UserName == UserName
                       select u;

            return Ok(await user.FirstOrDefaultAsync());
        }

        [HttpGet("api/add-birthday")]
        public async Task<IActionResult> AddBirthday(string UserName, string birthday)
        {
            var user = await (from u in _context.Users
                              where u.UserName == UserName
                              select u).FirstOrDefaultAsync();
            user!.Birthday = birthday;
            _context.SaveChanges();

            return Ok(user);
        }


    }
}
