namespace API.ProjectGeneration.Projects
{
    using API.ProjectGeneration.FileSystem;

    public interface IRenderableProject
    {
        string Name { get; }

        void Render(IFolder projectRoot);
    }
}