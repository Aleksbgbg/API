namespace Api.Areas.Services
{
    using System;
    using System.Text.RegularExpressions;

    using Api.Areas.WingmanTool.Models;

    public class ProjectQueryProvider : IProjectQueryProvider
    {
        public bool IsSupported(string projectType)
        {
            return Regex.IsMatch(projectType, "^[A-Za-z]+$") &&
                   Enum.TryParse(projectType, ignoreCase: true, out ProjectType _);
        }
    }
}