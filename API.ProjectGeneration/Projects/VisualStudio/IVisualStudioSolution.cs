namespace API.ProjectGeneration.Projects.VisualStudio
{
    using API.ProjectGeneration.FileSystem;
    using API.ProjectGeneration.Projects.VisualStudio.Cpp;
    using API.ProjectGeneration.Projects.VisualStudio.Cs;

    public interface IVisualStudioSolution
    {
        ICppProject AddCppProject();

        ICsharpProject AddCsharpProject(string name);

        FileSystemSnapshot Render();
    }
}