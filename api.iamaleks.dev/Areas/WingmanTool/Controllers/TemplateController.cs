namespace Api.Areas.WingmanTool.Controllers
{
    using Api.Areas.Services;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Area("WingmanTool")]
    [Route("[Area]/[Controller]/[Action]")]
    public class TemplateController : ControllerBase
    {
        private readonly IProjectQueryProvider _projectQueryProvider;

        public TemplateController(IProjectQueryProvider projectQueryProvider)
        {
            _projectQueryProvider = projectQueryProvider;
        }

        [HttpGet("{projectType}")]
        public bool IsSupported(string projectType)
        {
            return _projectQueryProvider.IsSupported(projectType);
        }
    }
}