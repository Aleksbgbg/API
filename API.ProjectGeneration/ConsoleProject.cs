namespace API.ProjectGeneration
{
    using System;

    public class ConsoleProject : RenderableProjectBase, IConsoleProject
    {
        private Action<IFolder> _projectRootConfiguration;

        public ConsoleProject(string name) : base(name)
        {
        }

        public IConsoleProject ConfigureProjectRoot(Action<IFolder> projectRootConfiguration)
        {
            _projectRootConfiguration = projectRootConfiguration;
            return this;
        }

        private protected override void AddCustomFiles(IFolder projectRoot)
        {
            _projectRootConfiguration?.Invoke(projectRoot);

            projectRoot.AddFile("Program")
                       .OfType(FileType.Cs);
        }
    }
}