namespace Api.Areas.WingmanTool.Services
{
    using Api.Areas.WingmanTool.Models;

    public interface IProjectQueryProvider
    {
        bool IsSupported(string projectType);

        string NormalizeProjectTypeString(string projectType);
    }
}