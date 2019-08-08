namespace API.ProjectGeneration
{
    using System.Linq;

    public static class FileTypeExtensions
    {
        public static string AsExtensionString(this FileType fileType)
        {
            return fileType.GetAttribute<FileExtensionAttribute>()
                           .FileExtension;
        }
    }
}