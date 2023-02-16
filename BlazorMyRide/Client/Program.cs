global using BlazorMyRide.Client.Services.CarService;
global using BlazorMyRide.Client.Services.CustomService;
global using BlazorMyRide.Shared;
using BlazorMyRide.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<ICustomService, CustomService>();

builder.Services.AddHttpClient("BlazorMyRide.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BlazorMyRide.ServerAPI"));

await builder.Build().RunAsync();
