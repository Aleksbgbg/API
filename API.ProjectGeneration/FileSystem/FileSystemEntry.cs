namespace API.ProjectGeneration.FileSystem
{
    using System.IO;
    using System.Text;

    public class FileSystemEntry
    {
        private readonly StringBuilder _relativePath;

        public FileSystemEntry(string relativePath, bool isDirectory)
        {
            _relativePath = new StringBuilder(relativePath);
            IsDirectory = isDirectory;
        }

        public string RelativePath => _relativePath.ToString();

        public bool IsDirectory { get; }

        public void AddParent(FileSystemEntry fileSystemEntry)
        {
            _relativePath.Insert(0, Path.DirectorySeparatorChar);
            _relativePath.Insert(0, fileSystemEntry.RelativePath);
        }

        public void AddExtension(string extension)
        {
            _relativePath.Append(extension);
        }
    }
}