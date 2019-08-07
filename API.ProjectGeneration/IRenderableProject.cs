namespace API.ProjectGeneration
{
    public interface IRenderableProject
    {
        FileSystemSnapshot Render();
    }
}