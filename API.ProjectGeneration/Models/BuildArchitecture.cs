namespace API.ProjectGeneration.Models
{
    using API.ProjectGeneration.Attributes;

    public enum BuildArchitecture
    {
        [AsString("x86")]
        [PlatformString("Win32")]
        x86,
        [AsString("x64")]
        [PlatformString("x64")]
        x64,
        [AsString("Any CPU")]
        [PlatformString("Any CPU")]
        AnyCPU
    }
}