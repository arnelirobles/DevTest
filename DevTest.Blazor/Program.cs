using DevTest.Blazor;
using DevTest.Blazor.DataAccess;
using DevTest.Blazor.Utilities.Utilities;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSingleton<ILocalStorage, LocalStorage>();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddRefitClient<IDevReg>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://api.devreg.org/api/v1");  
}
);

await builder.Build().RunAsync();
