namespace API.ProjectGeneration.Projects
{
    using API.ProjectGeneration.FileSystem;
    using API.ProjectGeneration.Models;

    public class RenderableProjectBase : IRenderableProject
    {
        public RenderableProjectBase(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Render(IFolder projectRoot)
        {
            projectRoot.AddFile(Name).OfType(FileType.Csproj);

            AddCustomFiles(projectRoot);
        }

        private protected virtual void AddCustomFiles(IFolder projectRoot)
        {
        }
    }
}