namespace API.ProjectGeneration.Projects
{
    using API.ProjectGeneration.Projects.VisualStudio;

    public static class CreateProject
    {
        public static IVisualStudioSolution VisualStudio(string name)
        {
            return new VisualStudioSolution(name);
        }
    }
}