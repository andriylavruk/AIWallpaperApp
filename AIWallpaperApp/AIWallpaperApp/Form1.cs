using AIWallpaperApp.Services;
using System.Drawing.Imaging;

namespace AIWallpaperApp;

public partial class Form1 : Form
{
    private readonly IImageService _imageService;

    public Form1(IImageService imageService)
    {
        InitializeComponent();

        _imageService = imageService;
    }

    private async void btnGenerate_Click(object sender, EventArgs e)
    {
        var prompt = textBoxPrompt.Text;
        var response = await _imageService.GenerateImageAsync(prompt);

        using (var ms = new MemoryStream(await response.Content.ReadAsByteArrayAsync()))
        {
            var image = Image.FromStream(ms);

            var imageName = @"img_" + Guid.NewGuid() + ".jpg";
            var directory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;

            image.Save(imageName, ImageFormat.Jpeg);
            FileInfo img__ = new FileInfo(imageName);
            img__.MoveTo(directory + "\\Images\\" + imageName);

            picBox.Image = image;
        }
    }
}
