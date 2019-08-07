namespace API.ProjectGeneration
{
    public interface IFile
    {
        IFile OfType(FileType fileType);

        IFile WithContent(string content);
    }
}