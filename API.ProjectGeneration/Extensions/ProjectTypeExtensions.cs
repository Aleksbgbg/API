namespace API.ProjectGeneration.Extensions
{
    using API.ProjectGeneration.Attributes;
    using API.ProjectGeneration.Models;

    public static class ProjectTypeExtensions
    {
        public static BuildArchitecture[] GetBuildArchitectures(this ProjectType projectType)
        {
            return projectType.GetAttribute<BuildArchitecturesAttribute>()
                              .BuildArchitectures;
        }

        public static string GetFileExtension(this ProjectType projectType)
        {
            return projectType.GetAttribute<FileExtensionAttribute>()
                              .FileExtension;
        }
    }
}