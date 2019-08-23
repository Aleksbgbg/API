namespace API.ProjectGeneration.FileSystem
{
    public class Folder : IFolder
    {
        private readonly FileSystemSnapshot _fileSystemSnapshot;

        private readonly FileSystemEntry _this;

        public Folder(string name, FileSystemSnapshot fileSystemSnapshot)
        {
            _fileSystemSnapshot = fileSystemSnapshot;
            _this = new FileSystemEntry(name, true);

            _fileSystemSnapshot.Add(_this);
        }

        public Folder(string name, FileSystemSnapshot fileSystemSnapshot, FileSystemEntry parent)
        {
            _fileSystemSnapshot = fileSystemSnapshot;
            _this = new FileSystemEntry(name, true);

            _fileSystemSnapshot.Add(_this, parent);
        }

        public IFile AddFile(string name)
        {
            File file = new File(name, _fileSystemSnapshot, _this);
            return file;
        }

        public IFolder AddFolder(string name)
        {
            Folder folder = new Folder(name, _fileSystemSnapshot, _this);
            return folder;
        }
    }
}