namespace API.ProjectGeneration.Projects.VisualStudio.Cs
{
    public interface ICsharpProject
    {
        IWpfProject UseWpf();

        IConsoleProject UseConsole();
    }
}