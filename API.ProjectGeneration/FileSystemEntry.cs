namespace API.ProjectGeneration
{
    public class FileSystemEntry
    {
        public FileSystemEntry(string relativePath, bool isDirectory)
        {
            RelativePath = relativePath;
            IsDirectory = isDirectory;
        }

        public string RelativePath { get; set; }

        public bool IsDirectory { get; }
    }
}