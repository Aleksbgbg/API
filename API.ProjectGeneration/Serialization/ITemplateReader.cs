namespace API.ProjectGeneration.Serialization
{
    using API.ProjectGeneration.Models;

    public interface ITemplateReader
    {
        string ReadTemplate(TemplateType templateType);
    }
}