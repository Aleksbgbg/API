namespace Api.Areas.WingmanTool.Controllers
{
    using Api.Areas.Services;
    using Api.Areas.WingmanTool.Models;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Area("WingmanTool")]
    [Route("[Area]/[Controller]")]
    public class TemplateController : ControllerBase
    {
        private readonly IProjectQueryProvider _projectQueryProvider;

        private readonly IProjectTemplateProducer _projectTemplateProducer;

        public TemplateController(IProjectQueryProvider projectQueryProvider, IProjectTemplateProducer projectTemplateProducer)
        {
            _projectQueryProvider = projectQueryProvider;
            _projectTemplateProducer = projectTemplateProducer;
        }

        [HttpGet("[Action]/{projectType}")]
        public bool IsSupported(string projectType)
        {
            return _projectQueryProvider.IsSupported(projectType);
        }

        [HttpGet("{projectType}/{projectName}")]
        public ActionResult<FileTreeTemplate> FileTreeTemplate(string projectType, string projectName)
        {
            if (!_projectQueryProvider.IsSupported(projectType))
            {
                return BadRequest("Unsupported project type.");
            }

            return _projectTemplateProducer.ProduceTemplateFor(projectType, projectName);
        }
    }
}