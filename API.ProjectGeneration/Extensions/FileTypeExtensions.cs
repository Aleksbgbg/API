namespace API.ProjectGeneration.Extensions
{
    using API.ProjectGeneration.Attributes;
    using API.ProjectGeneration.Models;

    public static class FileTypeExtensions
    {
        public static string GetExtension(this FileType fileType)
        {
            return fileType.GetAttribute<FileExtensionAttribute>()
                           .FileExtension;
        }
    }
}