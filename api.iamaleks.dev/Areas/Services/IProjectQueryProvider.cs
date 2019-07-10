namespace Api.Areas.Services
{
    public interface IProjectQueryProvider
    {
        bool IsSupported(string projectType);
    }
}