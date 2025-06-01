using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FluentUI.AspNetCore.Components;
using Detrav.Blazor.Shared;
using Detrav.Blazor.Shared.Services;
using Detrav.Blazor.Wasm.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Detrav.Blazor.Wasm
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<Routes>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddFluentUIComponents();

            // Add device-specific services used by the Detrav.Blazor.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();





            await builder.Build().RunAsync();
        }
    }
}
