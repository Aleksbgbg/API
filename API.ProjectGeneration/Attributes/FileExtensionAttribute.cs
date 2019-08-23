namespace API.ProjectGeneration.Attributes
{
    using System;
    using System.Diagnostics;

    [AttributeUsage(AttributeTargets.Field)]
    public class FileExtensionAttribute : Attribute
    {
        public FileExtensionAttribute(string fileExtension)
        {
            Debug.Assert(fileExtension.StartsWith("."));
            FileExtension = fileExtension;
        }

        public string FileExtension { get; }
    }
}