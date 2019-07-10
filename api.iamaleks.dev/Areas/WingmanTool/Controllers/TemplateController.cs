namespace Api.Areas.WingmanTool.Controllers
{
    using System;
    using System.Text.RegularExpressions;

    using Api.Areas.WingmanTool.Models;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Area("WingmanTool")]
    [Route("[Area]/[Controller]/[Action]")]
    public class TemplateController : ControllerBase
    {
        [HttpGet("{projectType}")]
        public bool IsSupported(string projectType)
        {
            return Regex.IsMatch(projectType, "^[A-Za-z]+$") &&
                   Enum.TryParse(projectType, ignoreCase: true, out ProjectType _);
        }
    }
}