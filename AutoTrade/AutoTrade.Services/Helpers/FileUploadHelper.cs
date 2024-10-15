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
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            profilePicture.CopyTo(stream);
        }

        return Path.Combine("/uploads", fileName);
    }
}
