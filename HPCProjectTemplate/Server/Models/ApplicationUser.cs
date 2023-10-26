using Duende.IdentityServer.EntityFramework.Options;
using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Options;

namespace HPCProjectTemplate.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Birthday { get; set; }

        public List<Plant> FavoritePlants { get; set; } = new();
        //public List<Posts> Posts { get; set; } = new();
        //public List<Replies> Replies { get; set } = new();
    }
}