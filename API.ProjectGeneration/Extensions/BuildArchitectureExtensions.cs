namespace API.ProjectGeneration.Extensions
{
    using API.ProjectGeneration.Attributes;
    using API.ProjectGeneration.Models;

    public static class BuildArchitectureExtensions
    {
        public static string AsPlatformString(this BuildArchitecture buildArchitecture)
        {
            return buildArchitecture.GetAttribute<PlatformStringAttribute>()
                                    .PlatformString;
        }
    }
}