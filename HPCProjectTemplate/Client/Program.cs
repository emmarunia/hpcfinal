using HPCProjectTemplate.Client;
using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

//using HPCProjectTemplate.Client.HttpRepository;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("HPCProjectTemplate.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("HPCProjectTemplate.ServerAPI"));
//builder.Services.AddScoped<IUserPlantsHttpRepository, UserPlantsHttpRepository>();

builder.Services.AddApiAuthorization();
//builder.Services.AddSyncfusionBlazor();
await builder.Build().RunAsync();



