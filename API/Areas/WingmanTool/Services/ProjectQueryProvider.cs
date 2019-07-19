namespace Api.Areas.WingmanTool.Services
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

        public string NormalizeProjectTypeString(string projectType)
        {
            ProjectType projectTypeEnum = Enum.Parse<ProjectType>(projectType, ignoreCase: true);

            return projectTypeEnum.ToString();
        }
    }
}