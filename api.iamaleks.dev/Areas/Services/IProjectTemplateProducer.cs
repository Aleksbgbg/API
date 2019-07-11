namespace Api.Areas.Services
{
    using System.Threading.Tasks;

    using Api.Areas.WingmanTool.Models;

    public interface IProjectTemplateProducer
    {
        FileTreeTemplate ProduceTemplateFor(string projectType);

        Task<string> RenderFile(string projectType, string projectName, string relativePath);
    }
}