namespace Api.Areas.WingmanTool.Controllers
{
    using System.Threading.Tasks;

    using Api.Areas.WingmanTool.Services;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Area("WingmanTool")]
    [Route("[Area]/[Controller]")]
    public class GitController
    {
        private readonly IGitFileProvider _gitFileProvider;

        public GitController(IGitFileProvider gitFileProvider)
        {
            _gitFileProvider = gitFileProvider;
        }

        [HttpGet("attributes")]
        public Task<string> GitAttributes()
        {
            return _gitFileProvider.ReadGitAttributes();
        }

        [HttpGet("ignore")]
        public Task<string> GitIgnore()
        {
            return _gitFileProvider.ReadGitIgnore();
        }
    }
}