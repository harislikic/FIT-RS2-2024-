using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using Microsoft.AspNetCore.Http;

public static class FileUploadHelper
{
    public static string UploadProfilePicture(IFormFile profilePicture)
    {
        if (profilePicture == null)
        {
            return null;
        }

        var fileName = Path.GetFileName(profilePicture.FileName);
        var fileExtension = Path.GetExtension(fileName).ToLowerInvariant();
        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "uploads");

        var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };

        if (!allowedExtensions.Contains(fileExtension))
        {
            throw new InvalidOperationException("Unsupported file format. Allowed formats are: jpg, jpeg, png.");
        }

        if (!Directory.Exists(uploadsFolder))
        {
            Directory.CreateDirectory(uploadsFolder);
        }

        var filePath = Path.Combine(uploadsFolder, fileName);

        using (var image = Image.Load(profilePicture.OpenReadStream()))
        {

            image.Mutate(x => x.Resize(new ResizeOptions
            {
                Size = new Size(1200, 1200),
                Mode = ResizeMode.Max
            }));


            var encoder = new SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder()
            {
                Quality = 95
            };

            image.Save(filePath, encoder);
        }

        return Path.Combine("/uploads", fileName);
    }
}
