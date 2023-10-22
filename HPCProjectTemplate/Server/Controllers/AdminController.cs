using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HPCProjectTemplate.Server.Data;
using HPCProjectTemplate.Server.Models;
using HPCProjectTemplate.Shared;
using System.Data;
using System.Threading.Tasks.Dataflow;
using static System.Net.WebRequestMethods;

namespace HPCProjectTemplate.Server.Controllers;

public class AdminController : Controller
{

    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public AdminController(UserManager<ApplicationUser> userManager,
                            RoleManager<IdentityRole> roleManager,
                            ApplicationDbContext context)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _context = context;
    }

    [HttpGet("api/become-premium-member")]

    public async Task<IActionResult> becomePremiumMember(string UserName)
    {

        var userId = await (from u in _context.Users
                            where u.UserName == UserName
                            select u.Id).FirstOrDefaultAsync();

        var user = await _userManager.FindByIdAsync(userId!);

        var isStandard = await _userManager.IsInRoleAsync(user!, "Standard");
        var isNull = await _userManager.IsInRoleAsync(user!, "NULL");

        if (isStandard)
        {
            await _userManager.RemoveFromRoleAsync(user!, "Standard");
            await _userManager.AddToRoleAsync(user!, "Premium");
        }
        if (isNull)
        {
            await _userManager.RemoveFromRoleAsync(user!, "NULL");
            await _userManager.AddToRoleAsync(user!, "Premium");
        }
        else
        {

        }

        _context.SaveChanges();
        return Ok(user);
    }
}
