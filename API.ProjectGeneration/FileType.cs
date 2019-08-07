namespace API.ProjectGeneration
{
    public enum FileType
    {
        [FileExtension(".xaml")]
        Xaml,
        [FileExtension(".xaml.cs")]
        XamlCs,
        [FileExtension(".cs")]
        Cs,
        [FileExtension(".csproj")]
        Csproj,
        [FileExtension(".sln")]
        Sln
    }
}