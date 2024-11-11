using AIWallpaperApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AIWallpaperApp;

internal static class Program
{
    public static IServiceProvider? ServiceProvider { get; private set; }

    [STAThread]
    static void Main()
    {
        var host = HostBuilderService.CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        Application.EnableVisualStyles();
        Application.Run(ServiceProvider.GetRequiredService<Form1>());
    }
}