using Duende.IdentityServer.EntityFramework.Options;
using HPCProjectTemplate.Server.Models;
using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HPCProjectTemplate.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PlantList>()
                .Property(m => m.license_name)
                .IsRequired(false);
            builder.Entity<PlantList>()
                .Property(m => m.license_url)
                .IsRequired(false);
            builder.Entity<PlantList>()
                .Property(m => m.original_url)
                .IsRequired(false);
            builder.Entity<PlantList>()
                .Property(m => m.medium_url)
                .IsRequired(false);
            builder.Entity<PlantList>()
                .Property(m => m.small_url)
                .IsRequired(false);
            builder.Entity<PlantList>()
                .Property(m => m.regular_url)
                .IsRequired(false);
            builder.Entity<PlantList>()
                .Property(m => m.thumbnail)
                .IsRequired(false);
        }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Plant> Plants { get; set; }

        public virtual DbSet<PlantList> PlantList { get; set; }
    }
}