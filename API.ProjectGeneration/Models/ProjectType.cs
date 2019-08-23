namespace API.ProjectGeneration.Models
{
    using API.ProjectGeneration.Attributes;

    public enum ProjectType
    {
        [BuildArchitectures(BuildArchitecture.AnyCPU)]
        [FileExtension(".csproj")]
        Csharp,
        [BuildArchitectures(BuildArchitecture.x64, BuildArchitecture.x86)]
        [FileExtension(".vcxproj")]
        Cpp
    }
}