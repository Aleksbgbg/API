namespace API.ProjectGeneration
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    public class FileExtensionAttribute : Attribute
    {
        public FileExtensionAttribute(string extension)
        {
            Extension = extension;
        }

        public string Extension { get; }
    }
}