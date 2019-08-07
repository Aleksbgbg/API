namespace API.ProjectGeneration
{
    public interface ICsharpProject
    {
        IWpfProject UseWpf();

        IConsoleProject UseConsole();
    }
}