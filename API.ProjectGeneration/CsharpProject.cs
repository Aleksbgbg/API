namespace API.ProjectGeneration
{
    public class CsharpProject : ICsharpProject, IRenderableProject
    {
        private readonly string _name;

        private IRenderableProject _renderableProject;

        public CsharpProject(string name)
        {
            _name = name;
        }

        public IWpfProject UseWpf()
        {
            WpfProject wpfProject = new WpfProject(_name);
            _renderableProject = wpfProject;
            return wpfProject;
        }

        public IConsoleProject UseConsole()
        {
            ConsoleProject consoleProject = new ConsoleProject(_name);
            _renderableProject = consoleProject;
            return consoleProject;
        }

        public FileSystemSnapshot Render()
        {
            return _renderableProject.Render();
        }
    }
}