namespace API.ProjectGeneration
{
    public class File : IFile
    {
        private readonly FileSystemEntry _fileSystemEntry;

        public File(string name, FileSystemSnapshot fileSystemSnapshot, FileSystemEntry parent)
        {
            _fileSystemEntry = new FileSystemEntry(name, false);

            fileSystemSnapshot.Add(_fileSystemEntry, parent);
        }

        public IFile OfType(FileType fileType)
        {
            _fileSystemEntry.RelativePath += fileType.AsExtensionString();
            return this;
        }

        public IFile WithContent(string content)
        {
            // TODO: Content rendering
            return this;
        }
    }
}