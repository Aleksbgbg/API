namespace Api.Areas.WingmanTool.Services
{
    public interface IProjectQueryProvider
    {
        bool IsSupported(string projectType);
    }
}