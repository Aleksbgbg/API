namespace API.ProjectGeneration.FileSystem
{
    using API.ProjectGeneration.Extensions;
    using API.ProjectGeneration.Models;

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
            _fileSystemEntry.AddExtension(fileType.GetExtension());
            return this;
        }

        public IFile WithContent(string content)
        {
            // TODO: Content rendering
            return this;
        }
    }
}