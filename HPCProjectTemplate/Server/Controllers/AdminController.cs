﻿using Microsoft.AspNetCore.Identity;
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
    private readonly ILogger<AdminController> _logger;

    public AdminController(UserManager<ApplicationUser> userManager,
                            RoleManager<IdentityRole> roleManager,
                            ApplicationDbContext context,
                            ILogger<AdminController> logger)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _context = context;
        _logger = logger;
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

    [HttpGet("api/admin")]
    public async Task<List<UserRoles>> Get()
    {
        try
        {
            var users = _userManager.Users.Select(u => new UserRoles()
            {
                Id = u.Id,
                UserName = u.UserName,
                Roles = _userManager.GetRolesAsync(u).Result.ToArray()
            }).ToList();
            // do not use interpolated string in logging (performance issue)
            _logger.LogInformation("Getting Users/Roles.");
            /*  0=Trace
                1=Debug
                2=Information
                3=Warning
                4=Error
                5=Critical
                6=None
            */
            return users;
        }
        catch (Exception ex)
        {
            _logger.LogError("Error in Admin Controller, Get method, Error: {0}", ex.Message);
            return new List<UserRoles>();
        }

    }

    [HttpGet("api/admin/{id}")]
    public async Task<ActionResult<EditUser>> Get(string id)
    {
        _logger.LogInformation("Editing user: {0}", id);
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
        {
            _logger.LogError("User {0} not found", id);
            return NotFound();
        }

        var userRoles = await _userManager.GetRolesAsync(user);

        var userEditDto = new EditUser()
        {
            Id = user.Id,
            UserName = user.UserName,
            Email = user.Email,
            EmailConfirmed = user.EmailConfirmed,
            IsAdmin = userRoles.Contains("Admin"),
            FirstName = user.FirstName,
            LastName = user.LastName
        };

        return Ok(userEditDto);
    }

    [HttpPost("api/toggle-admin-role")]
    public async Task<IActionResult> ToggleAdminRole([FromBody] string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return NotFound();
        }

        var isAdmin = await _userManager.IsInRoleAsync(user, "Admin");
        if (isAdmin)
        {
            await _userManager.RemoveFromRoleAsync(user, "Admin");
        }
        else
        {
            await _userManager.AddToRoleAsync(user, "Admin");
        }

        return Ok();
    }

    [HttpPut("api/admin")]
    public async Task<IActionResult> Put([FromBody] EditUser userEdit)
    {

        var user = await _userManager.FindByIdAsync(userEdit.Id);
        if (user == null)
        {
            return NotFound();
        }

        user.UserName = userEdit.UserName;
        user.Email = userEdit.Email;
        user.EmailConfirmed = userEdit.EmailConfirmed;
        user.FirstName = userEdit.FirstName;
        user.LastName = userEdit.LastName;

        var userRoles = await _userManager.GetRolesAsync(user);
        var isAdmin = userRoles.Contains("Admin");
        if (isAdmin && !userEdit.IsAdmin)
        {
            await _userManager.RemoveFromRoleAsync(user, "Admin");
        }
        else if (!isAdmin && userEdit.IsAdmin)
        {
            await _userManager.AddToRoleAsync(user, "Admin");
        }

        await _userManager.UpdateAsync(user);

        return Ok();

    }
}
