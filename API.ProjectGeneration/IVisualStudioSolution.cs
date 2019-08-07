namespace API.ProjectGeneration
{
    public interface IVisualStudioSolution
    {
        ICppProject AddCppProject();

        ICsharpProject AddCsharpProject(string name);

        FileSystemSnapshot Render();
    }
}