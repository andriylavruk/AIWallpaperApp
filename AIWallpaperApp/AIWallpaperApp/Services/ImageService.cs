using AIWallpaperApp.Models;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;

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
        var data = new
        {
            prompt = prompt!,
            negative_prompt = "low quality, blurry",
            steps = 25,
            guidance_scale = 5.5,
            seed = 98552302,
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
}
