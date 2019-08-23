namespace API.ProjectGeneration.FileSystem
{
    public interface IFolder
    {
        IFile AddFile(string name);

        IFolder AddFolder(string name);
    }
}