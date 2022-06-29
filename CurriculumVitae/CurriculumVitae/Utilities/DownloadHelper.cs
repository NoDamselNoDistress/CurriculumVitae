﻿namespace CurriculumVitae.Utilities
{
    public class DownloadHelper
    {

        public async Task<string> DownloadImageAsync(string directoryPath, string fileName, Uri uri)
        {
            using var httpClient = new HttpClient();

            // Get the file extension
            var uriWithoutQuery = uri.GetLeftPart(UriPartial.Path);
            var fileExtension = Path.GetExtension(uriWithoutQuery);

            // Create file path and ensure directory exists
            var path = Path.Combine(directoryPath, $"{fileName}{fileExtension}");
            Directory.CreateDirectory(directoryPath);

            // Download the image and write to the file
            var imageBytes = await httpClient.GetByteArrayAsync(uri);

            await File.WriteAllBytesAsync(path, imageBytes);
            return path;

        }
        
    }
}
