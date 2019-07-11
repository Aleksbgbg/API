namespace Api.Areas.WingmanTool.Controllers
{
    using System.Threading.Tasks;

    using Api.Areas.WingmanTool.Models;
    using Api.Areas.WingmanTool.Services;

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

        [HttpGet("{projectType}")]
        public ActionResult<FileTreeTemplate> FileTreeTemplate(string projectType)
        {
            if (!_projectQueryProvider.IsSupported(projectType))
            {
                return UnsupportedProjectType();
            }

            return _projectTemplateProducer.ProduceTemplateFor(projectType);
        }

        [HttpGet("File/{projectType}/{projectName}")]
        public async Task<ActionResult<string>> RenderFile(string projectType, string projectName, string relativePath)
        {
            if (!_projectQueryProvider.IsSupported(projectType))
            {
                return UnsupportedProjectType();
            }

            return await _projectTemplateProducer.RenderFile(projectType, projectName, relativePath);
        }

        private ActionResult UnsupportedProjectType()
        {
            return BadRequest("Unsupported project type.");
        }
    }
}