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

        if (response.IsSuccessStatusCode)
        {
            using (var ms = new MemoryStream(await response.Content.ReadAsByteArrayAsync()))
            using (var image = Image.FromStream(ms))
            {
                var imageName = @"img_" + Guid.NewGuid() + ".jpg";
                var directory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
                var moveToDirectory = directory + "\\Images\\" + imageName;

                image.Save(imageName, ImageFormat.Jpeg);
                var imageFileInfo = new FileInfo(imageName);
                imageFileInfo.MoveTo(moveToDirectory);

                picBox.ImageLocation = moveToDirectory;
            }
        }
        else
        {
            MessageBox.Show(response.StatusCode.ToString());
        }
    }

    private void btnSetWallpaper_Click(object sender, EventArgs e)
    {
        _imageService.SetWallpaper(picBox.ImageLocation);
    }

    private void textBoxPrompt_TextChanged(object sender, EventArgs e)
    {
        btnGenerate.Enabled = !string.IsNullOrWhiteSpace(textBoxPrompt.Text);
    }
}
