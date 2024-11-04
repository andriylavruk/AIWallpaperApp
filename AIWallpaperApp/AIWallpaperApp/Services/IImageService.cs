namespace AIWallpaperApp.Services;

public interface IImageService
{
    Task<HttpResponseMessage> GenerateImageAsync(string prompt);
}