namespace API.ProjectGeneration.FileSystem
{
    using API.ProjectGeneration.Models;

    public interface IFile
    {
        IFile OfType(FileType fileType);

        IFile WithContent(string content);
    }
}