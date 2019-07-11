namespace Api.Areas.Services
{
    using Api.Areas.WingmanTool.Models;

    public interface IProjectTemplateProducer
    {
        FileTreeTemplate ProduceTemplateFor(string projectType, string projectName);
    }
}