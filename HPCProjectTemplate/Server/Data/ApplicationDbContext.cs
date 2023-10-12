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
            builder.Entity<Product>()
                .HasKey(p => p.id);
            builder.Entity<Product>().HasData(
                new Product { id = 1, name = "Plant Food", brand = "Schultz", price = 11.99 },
                new Product { id = 2, name = "Watering Can", brand = "The Sill", price = 15.00 },
                new Product { id = 3, name = "Hose", brand = "RestMo", price = 19.99 },
                new Product { id = 4, name = "Hose Nozzle", brand = "J&B", price = 79.95 },
                new Product { id = 5, name = "Gardening Gloves", brand = "Cool Job", price = 9.99 },
                new Product { id = 6, name = "Small Pot", brand = "Trendspot", price = 15.00 },
                new Product { id = 7, name = "Medium Pot", brand = "Bloem Terra", price = 15.66 },
                new Product { id = 8, name = "Large Pot", brand = "Style Selections", price = 16.98 },
                new Product { id = 9, name = "Spray Bottle", brand = "Aplree", price = 9.99 },
                new Product { id = 10, name = "Potting Soil", brand = "Fox Farm", price = 23.99 },
                new Product { id = 11, name = "Plant Saucer", brand = "Growneer", price = 14.99 },
                new Product { id = 12, name = "Soil Moisture Meter", brand = "Gouevn", price = 8.97 },
                new Product { id = 13, name = "Watering Globes", brand = "Maxam", price = 17.95 },
                new Product { id = 14, name = "Pruning Shears", brand = "Flora Animalia", price = 24.00 },
                new Product { id = 15, name = "Outdoor Plant Stand", brand = "Roadwater", price = 32.99 },
                new Product { id = 16, name = "Indoor Plant Stand", brand = "PLantsHome", price = 20.99 },
                new Product { id = 17, name = "Humidifier", brand = "Honeywell", price = 41.99 },
                new Product { id = 18, name = "Gardening Tool Set", brand = "Leonard", price = 54.69 },
                new Product { id = 19, name = "LED Grow Light", brand = "Soltech Solutions", price = 149.99 },
                new Product { id = 20, name = "Hand Trowel", brand = "Fiskars", price = 12.99 }

            );
        }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Plant> Plants { get; set; }

        public virtual DbSet<PlantList> PlantList { get; set; }

        public virtual DbSet<Product> Products { get; set; }
    }
}