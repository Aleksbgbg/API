namespace API.ProjectGeneration.Projects.VisualStudio.Cs
{
    using System;

    using API.ProjectGeneration.FileSystem;
    using API.ProjectGeneration.Models;

    public class WpfProject : RenderableProjectBase, IWpfProject
    {
        private Action<IFolder> _projectRootConfiguration;

        public WpfProject(string name) : base(name)
        {
        }

        public IWpfProject ConfigureProjectRoot(Action<IFolder> projectRootConfiguration)
        {
            _projectRootConfiguration = projectRootConfiguration;
            return this;
        }

        private protected override void AddCustomFiles(IFolder projectRoot)
        {
            _projectRootConfiguration?.Invoke(projectRoot);

            projectRoot.AddFile("AppBootstrapper").OfType(FileType.Cs);

            projectRoot.AddFile("App").OfType(FileType.Xaml);
            projectRoot.AddFile("App").OfType(FileType.XamlCs);

            IFolder views = projectRoot.AddFolder("Views");

            views.AddFile("ShellView").OfType(FileType.Xaml);
            views.AddFile("ShellView").OfType(FileType.XamlCs);

            views.AddFile("MainView").OfType(FileType.Xaml);
            views.AddFile("MainView").OfType(FileType.XamlCs);

            IFolder viewModels = projectRoot.AddFolder("ViewModels");

            viewModels.AddFile("ShellViewModel").OfType(FileType.Cs);
            viewModels.AddFile("MainViewModel").OfType(FileType.Cs);

            IFolder viewModelInterfaces = viewModels.AddFolder("Interfaces");
            viewModelInterfaces.AddFile("IShellViewModel").OfType(FileType.Cs);
            viewModelInterfaces.AddFile("IMainViewModel").OfType(FileType.Cs);

            projectRoot.AddFolder("Models");

            IFolder themes = projectRoot.AddFolder("Themes");

            themes.AddFile("Brushes").OfType(FileType.Xaml);
            themes.AddFile("Images").OfType(FileType.Xaml);
            themes.AddFile("Styles").OfType(FileType.Xaml);

            projectRoot.AddFolder("Services");
            projectRoot.AddFolder("Helpers");
            projectRoot.AddFolder("Converters");
        }
    }
}