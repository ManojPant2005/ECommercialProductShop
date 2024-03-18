using Blazored.LocalStorage;
using ECommercial.Web;
using ECommercial.Web.Services.Contracts;
using ECommercial.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7055/") });

builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();

builder.Services.AddSyncfusionBlazor();
builder.Services.AddBlazoredLocalStorage();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licenseKey: "Ngo9BigBOggjHTQxAR8/V1NAaF5cWWJCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdgWH1cdXRWRGldWU1zXUU=");


builder.Services.AddScoped<IManageProductLocalStorageService, ManageProductsLocalStorageService>();
builder.Services.AddScoped<IManageCartItemsLocalStorageService, ManageCartItemsLocalStorageService>();

await builder.Build().RunAsync();


