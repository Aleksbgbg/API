namespace API.ProjectGeneration.Serialization
{
    public interface IFileRenderer<T>
            where T : class
    {
        string Render(T model);
    }
}