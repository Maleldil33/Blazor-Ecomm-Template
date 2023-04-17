global using ECommBlazor1.Shared.Models;
global using System.Net.Http.Json;
global using ECommBlazor1.Client.Services.ProductService;
global using ECommBlazor1.Client.Services.CategoryService;
global using Blazored.LocalStorage;
global using ECommBlazor1.Shared.DTO;
global using ECommBlazor1.Client.AuthService;
global using Microsoft.AspNetCore.Components.Authorization;
global using ECommBlazor1.Client.Services.CartService;
global using ECommBlazor1.Client.Services.OrderService;


using ECommBlazor1.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddOptions();
builder.Services.AddAuthenticationCore();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddBlazoredLocalStorage();


await builder.Build().RunAsync();
