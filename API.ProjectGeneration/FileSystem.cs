namespace API.ProjectGeneration
{
    public class FileSystem : IFileSystem
    {
        private readonly Folder _folder;

        public FileSystem(string name, FileSystemSnapshot fileSystemSnapshot)
        {
            _folder = new Folder(name, fileSystemSnapshot);
        }

        public IFile AddFile(string name)
        {
            return _folder.AddFile(name);
        }

        public IFolder AddFolder(string name)
        {
            return _folder.AddFolder(name);
        }
    }
}