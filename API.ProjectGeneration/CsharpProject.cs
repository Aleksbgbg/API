namespace API.ProjectGeneration
{
    public class CsharpProject : ICsharpProject, IRenderableProject
    {
        private IRenderableProject _renderableProject;

        public CsharpProject(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public IWpfProject UseWpf()
        {
            WpfProject wpfProject = new WpfProject(Name);
            _renderableProject = wpfProject;
            return wpfProject;
        }

        public IConsoleProject UseConsole()
        {
            ConsoleProject consoleProject = new ConsoleProject(Name);
            _renderableProject = consoleProject;
            return consoleProject;
        }

        public void Render(IFolder projectRoot)
        {
            _renderableProject.Render(projectRoot);
        }
    }
}