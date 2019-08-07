namespace API.ProjectGeneration
{
    public interface IVisualStudioSolution : IRenderableProject
    {
        ICppProject AddCppProject();

        ICsharpProject AddCsharpProject(string name);
    }
}