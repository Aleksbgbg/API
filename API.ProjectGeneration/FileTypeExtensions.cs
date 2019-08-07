namespace API.ProjectGeneration
{
    using System.Linq;

    public static class FileTypeExtensions
    {
        public static string AsExtensionString(this FileType fileType)
        {
            return fileType.GetType()
                           .GetMember(fileType.ToString())
                           .Single()
                           .GetCustomAttributes(typeof(FileExtensionAttribute), false)
                           .Cast<FileExtensionAttribute>()
                           .Single()
                           .Extension;
        }
    }
}