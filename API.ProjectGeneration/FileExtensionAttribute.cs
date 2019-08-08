namespace API.ProjectGeneration
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    public class FileExtensionAttribute : Attribute
    {
        public FileExtensionAttribute(string fileExtension)
        {
            FileExtension = fileExtension;
        }

        public string FileExtension { get; }
    }
}