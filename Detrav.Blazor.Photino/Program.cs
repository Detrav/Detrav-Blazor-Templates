using Microsoft.Extensions.DependencyInjection;
using Microsoft.FluentUI.AspNetCore.Components;
using Detrav.Blazor.Photino.Services;
using Detrav.Blazor.Shared;
using Detrav.Blazor.Shared.Services;
using Photino.Blazor;
using System;
using System.Net.Http;

namespace Detrav.Blazor.Photino
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var appBuilder = PhotinoBlazorAppBuilder.CreateDefault(args);

            appBuilder.Services
                .AddLogging();

            appBuilder.Services.AddFluentUIComponents();

            // Add device-specific services used by the Detrav.Blazor.Shared project
            appBuilder.Services.AddSingleton<IFormFactor, FormFactor>();

            // register root component and selector
            appBuilder.RootComponents.Add<Routes>("#app");

            var app = appBuilder.Build();

            // customize window
            app.MainWindow
                .SetIconFile("favicon.ico")
                .SetTitle("Detrav.Blazor.Photino");

            


            AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
            {
                app.MainWindow.ShowMessage("Fatal exception", error.ExceptionObject.ToString());
            };

            app.Run();

        }
    }
}