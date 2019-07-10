namespace Api.Areas.Services
{
    using Api.Areas.WingmanTool.Models;

    public interface IProjectQueryProvider
    {
        bool IsSupported(string projectType);

        FileTreeTemplate ProduceTemplateFor(string projectType, string projectName);

        string ReadFileContents(string projectType, FileTreeEntry file, string projectName);
    }
}