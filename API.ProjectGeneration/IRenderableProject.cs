namespace API.ProjectGeneration
{
    public interface IRenderableProject
    {
        string Name { get; }

        void Render(IFolder projectRoot);
    }
}