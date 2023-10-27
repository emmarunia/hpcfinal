using Microsoft.EntityFrameworkCore;
using HPCProjectTemplate.Server.Data;
using HPCProjectTemplate.Shared;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.Extensions.Options;

namespace HPCProjectTemplate.Server;
public static class SeedData
{
    public static void Initialize(IServiceProvider service)
    {
        OperationalStoreOptions storeOptions = new OperationalStoreOptions
        {
    
        };
    

        IOptions<OperationalStoreOptions> operationalStoreOptions = Options.Create(storeOptions);

        using (var context = new ApplicationDbContext(service.GetRequiredService<DbContextOptions<ApplicationDbContext>>(),operationalStoreOptions))
        {
            if (context.PlantList.Any())
            {
                return;
            }
            var env = service.GetRequiredService<IWebHostEnvironment>();
            var path = Path.Combine(env.ContentRootPath, "plantData.json");
            var jsonString = System.IO.File.ReadAllText(path);
            if (jsonString is not null)
            {
                #pragma warning disable CS8600
                List<PlantList> pl = System.Text.Json.JsonSerializer.Deserialize<List<PlantList>>(jsonString);
                #pragma warning restore CS8600

                if(pl is not null)
                {
                    foreach(var plant in pl)
                    {
                        context.PlantList.Add(plant);
                    }
                    context.Database.OpenConnection();
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[PlantList] ON");
                    context.SaveChanges();
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[PlantList] OFF");
                    context.Database.CloseConnection();
                }

            }
        }

    }
}
