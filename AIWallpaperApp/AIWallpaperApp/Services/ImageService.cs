using AIWallpaperApp.Models;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using System.Runtime.InteropServices;

namespace AIWallpaperApp.Services;

public class ImageService : IImageService
{
    private readonly AppSettings _settings;

    public ImageService(IOptions<AppSettings> settings)
    {
        _settings = settings.Value;
    }

    public async Task<HttpResponseMessage> GenerateImageAsync(string prompt)
    {
        var random = new Random();
        var randomSeed = random.Next(0, int.MaxValue);

        var data = new
        {
            prompt = prompt!,
            negative_prompt = "low quality, blurry",
            steps = 25,
            guidance_scale = 5.5,
            seed = randomSeed,
            sampler = "euler",
            scheduler = "sgm_uniform",
            width = 1792,
            height = 1024,
            aspect_ratio = "custom",
            batch_size = 1,
            image_format = "jpeg",
            image_quality = 95,
            base64 = false
        };

        using (HttpClient httpClient = new HttpClient())
        {
            var request = new HttpRequestMessage(HttpMethod.Post, new Uri(_settings.Url));
            request.Content = JsonContent.Create(data);
            request.Headers.Add("x-api-key", _settings.ApiKey);

            return await httpClient.SendAsync(request);
        }

    }

    public int SetWallpaper(string imagePath)
    {
         const int SPI_SETDESKWALLPAPER = 20;
         const int SPIF_UPDATEINFILE = 1;
         const int SPIF_SENDCHANGE = 2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        return SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imagePath, SPIF_UPDATEINFILE | SPIF_SENDCHANGE);
    }
}
