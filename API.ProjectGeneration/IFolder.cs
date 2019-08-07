namespace API.ProjectGeneration
{
    public interface IFolder
    {
        IFile AddFile(string name);

        IFolder AddFolder(string name);
    }
}