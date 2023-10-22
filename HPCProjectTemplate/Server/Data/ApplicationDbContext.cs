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
            builder.Entity<Plant>()
                .HasIndex(p => new { p.perenualId, p.ApplicationUserId }).IsUnique();
            builder.Entity<Product>()
                .HasKey(p => p.id);
            builder.Entity<Product>().HasData(
                new Product { id = 1, name = "Plant Food", brand = "Schultz", price = 11.99, 
                    link = "https://www.amazon.com/Schultz-Purpose-Plant-10-15-10-1012/dp/B00BARNKVI", 
                    imageURL = "https://m.media-amazon.com/images/I/71klu8s1ByL._AC_SL1500_.jpg"
                },
                new Product { id = 2, name = "Watering Can", brand = "The Sill", price = 15.00, 
                    link = "https://www.thesill.com/products/watering-can", 
                    imageURL = "https://m.media-amazon.com/images/I/61pbHrnjtiL.__AC_SX300_SY300_QL70_FMwebp_.jpg"
                },
                new Product { id = 3, name = "Hose Nozzle", brand = "RestMo", price = 19.99,
                    link = "https://a.co/d/5wWRADc",
                    imageURL = "https://m.media-amazon.com/images/I/6152WkWN1pL._AC_SL1500_.jpg"
                },
                new Product { id = 4, name = "Hose", brand = "J&B", price = 79.95,
                    link = "https://a.co/d/7cKk3Ko",
                    imageURL = "https://m.media-amazon.com/images/I/51f02NCHHZL._AC_.jpg"
                },
                new Product { id = 5, name = "Gardening Gloves", brand = "Cool Job", price = 9.99,
                    link = "https://a.co/d/8I984yK",
                    imageURL = "https://m.media-amazon.com/images/I/81-H4AxC-HL._AC_SL1500_.jpg"
                },
                new Product { id = 6, name = "Small Pot", brand = "Trendspot", price = 15.00,
                    link = "https://www.homedepot.com/p/Trendspot-6-in-White-Knack-Ceramic-Decorative-Planter-CR01721S-06W/314647810#overlay",
                    imageURL = "https://images.thdstatic.com/productImages/6f13eda0-b539-4f8e-af0b-efb8b7244c8b/svn/white-trendspot-plant-pots-cr01721s-06w-64_145.jpg"
                },
                new Product { id = 7, name = "Medium Pot", brand = "Bloem Terra", price = 15.66,
                    link = "https://www.homedepot.com/p/Bloem-Terra-16-in-Terra-Cotta-Plastic-Planter-50016C/301861355",
                    imageURL = "https://images.thdstatic.com/productImages/e96ac4ef-c26c-4650-9019-3d1620008850/svn/terra-cotta-bloem-plant-pots-50016c-64_145.jpg"
                },
                new Product { id = 8, name = "Large Pot", brand = "Style Selections", price = 16.98,
                    link = "https://www.lowes.com/pd/L-G-Solutions-19-3-in-W-x-12-1-in-H-Oak-Resin-Planter/50445052?cm_mmc=shp-_-c-_-prd-_-lwn-_-ggl-_-LIA_LWN_243_Planters-And-Outdoor-Decor-_-50445052-_-local-_-0-_-0&gclid=CjwKCAjwp8OpBhAFEiwAG7NaEm-5zdjPHY60pE4d1f2KqemFEiS5XFwjXcjXFBu_9pu2YFsbqq42XxoCkBsQAvD_BwE&gclsrc=aw.ds",
                    imageURL = "https://mobileimages.lowes.com/productimages/2d392f1f-0a01-43da-becd-a6dd0265a3fc/03943290.jpg?size=mthb"
                },
                new Product { id = 9, name = "Spray Bottle", brand = "Aplree", price = 9.99,
                    link = "https://a.co/d/fWtmOMk",
                    imageURL = "https://m.media-amazon.com/images/I/41v5rWcdioL._SY450_.jpg"
                },
                new Product { id = 10, name = "Potting Soil", brand = "Fox Farm", price = 23.99,
                    link = "https://a.co/d/626DZLq",
                    imageURL = "https://m.media-amazon.com/images/I/617QtlPIYkL._AC_SL1008_.jpg"
                },
                new Product { id = 11, name = "Plant Saucer", brand = "Growneer", price = 14.99,
                    link = "https://a.co/d/1EtpyHh",
                    imageURL = "https://m.media-amazon.com/images/I/61i6pPfDOXL._AC_SL1500_.jpg"
                },
                new Product { id = 12, name = "Soil Moisture Meter", brand = "Gouevn", price = 8.97,
                    link = "https://a.co/d/gdYMp7P",
                    imageURL = "https://m.media-amazon.com/images/I/61sql7HKnrL._AC_SL1000_.jpg"
                },
                new Product { id = 13, name = "Watering Globes", brand = "Maxam", price = 17.95,
                    link = "https://a.co/d/2TyK4q0",
                    imageURL = "https://m.media-amazon.com/images/I/81g9I5kaC4L._AC_SL1500_.jpg"
                },
                new Product { id = 14, name = "Pruning Shears", brand = "Flora Animalia", price = 24.00, 
                    link = "https://cna.st/p/meh9fHuiYWLjmKvrfKeMpz4Kmp7XkzM8Z5wUSR8sWe9M8i3hFgPgGoRQonNHa9bHj1Xthh1KnADaRjTy7qPnSAnKAcWXCCcxoaSoEPHh1sHE7eGUthXFx3SvdAcBdee2QFYigTAJSignYsFnEd57TA6QtZh58sB7LPAe8oh4a?xid=fr1697744462979iih", 
                    imageURL = "https://media.self.com/photos/613a28d4761c8e04eaf65719/3:4/w_1280%2Cc_limit/untitled-1.png" },
                new Product { id = 15, name = "Outdoor Plant Stand", brand = "Roadwater", price = 32.99,
                    link = "https://a.co/d/8gtjYit",
                    imageURL = "https://m.media-amazon.com/images/I/71lQbCwk-PL._AC_SL1500_.jpg"
                },
                new Product { id = 16, name = "Indoor Plant Stand", brand = "PlantsHome", price = 20.99,
                    link = "https://a.co/d/i28n7fc",
                    imageURL = "https://m.media-amazon.com/images/I/61lUweEadvL._AC_SL1500_.jpg"
                },
                new Product { id = 17, name = "Humidifier", brand = "Honeywell", price = 41.99,
                    link = "https://www.target.com/p/honeywell-cool-mist-ultrasonic-humidifier/-/A-14568404?clkid=ba631689N5ca111ee8ddeddd158242021&cpng=PTID1&lnm=81938&afid=Self%20Commerce&ref=tgt_adv_xasd0002#lnk=sametab",
                    imageURL = "https://target.scene7.com/is/image/Target/GUEST_4b9d1941-405f-4c08-a881-0fd3c5c8f0bd?wid=800&hei=800&qlt=80&fmt=webp"
                },
                new Product { id = 18, name = "Gardening Tool Set", brand = "Leonard", price = 54.69,
                    link = "https://www.amleo.com/leonard-complete-aluminum-gardening-tool-set/p/ATS1?utm_source=bing&utm_medium=cpc&utm_campaign=Bing%20Shopping%20%7C%20AM%20%7C%20Catch%20All&utm_term=&utm_content=301093518--1287528186799977--80470528555497&msclkid=d81a275df9081f3c4d65426c73b86712",
                    imageURL = "https://www.amleo.com/media/catalog/product/cache/aa1841770a2aa8b05bb5b429e42f9ba2/a/t/ats1.jpg"
                },
                new Product { id = 19, name = "LED Grow Light", brand = "Soltech Solutions", price = 149.99,
                    link = "https://a.co/d/dVNNsly",
                    imageURL = "https://m.media-amazon.com/images/I/61xA6AEkpKL._AC_SY679_.jpg"
                },
                new Product { id = 20, name = "Hand Trowel", brand = "Fiskars", price = 12.99,
                    link = "https://a.co/d/ceW5PG7",
                    imageURL = "https://m.media-amazon.com/images/I/51C6b3bd4AL._AC_SL1280_.jpg"
                }

            );
        }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Plant> Plants { get; set; }

        public virtual DbSet<PlantList> PlantList { get; set; }

        public virtual DbSet<Product> Products { get; set; }
    }
}