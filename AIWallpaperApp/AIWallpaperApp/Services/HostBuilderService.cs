using AIWallpaperApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace AIWallpaperApp.Services;

public static class HostBuilderService
{
    public static IHostBuilder CreateHostBuilder()
    {
        var config = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", false, true)
            .AddUserSecrets(Assembly.GetExecutingAssembly(), true)
            .AddEnvironmentVariables()
            .Build();

        var hostBuilder = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) => 
            {
                services.Configure<AppSettings>(config.GetSection("Segmind"));
                services.AddTransient<IImageService, ImageService>();
                services.AddSingleton<Form1>();
            });

        return hostBuilder;
    }
}
