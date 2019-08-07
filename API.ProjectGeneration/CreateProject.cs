namespace API.ProjectGeneration
{
    public static class CreateProject
    {
        public static IVisualStudioSolution VisualStudio(string name)
        {
            return new VisualStudioSolution(name);
        }
    }
}