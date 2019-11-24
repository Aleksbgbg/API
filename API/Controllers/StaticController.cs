namespace Api.Controllers
{
    using System.IO;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class StaticController : ControllerBase
    {
        [HttpGet("favicon.png")]
        public PhysicalFileResult GetFavicon()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "favicon.png"), "image/png");
        }
    }
}