namespace API.ProjectGeneration
{
    using System;

    public class WpfProject : RenderableProjectBase, IWpfProject
    {
        public WpfProject(string name) : base(name)
        {
        }

        public IWpfProject ConfigureFileSystem(Action<IFileSystem> configuration)
        {
            configuration(FileSystem);
            return this;
        }

        private protected override void AddCustomFiles(IFileSystem fileSystem)
        {
            fileSystem.AddFile("AppBootstrapper")
                      .OfType(FileType.Cs);

            fileSystem.AddFile("App")
                      .OfType(FileType.Xaml);
            fileSystem.AddFile("App")
                      .OfType(FileType.XamlCs);

            IFolder views = fileSystem.AddFolder("Views");

            views.AddFile("ShellView")
                 .OfType(FileType.Xaml);
            views.AddFile("ShellView")
                 .OfType(FileType.XamlCs);

            views.AddFile("MainView")
                 .OfType(FileType.Xaml);
            views.AddFile("MainView")
                 .OfType(FileType.XamlCs);

            IFolder viewModels = fileSystem.AddFolder("ViewModels");

            viewModels.AddFile("ShellViewModel")
                      .OfType(FileType.Cs);
            viewModels.AddFile("MainViewModel")
                      .OfType(FileType.Cs);

            IFolder viewModelInterfaces = viewModels.AddFolder("Interfaces");
            viewModelInterfaces.AddFile("IShellViewModel")
                               .OfType(FileType.Cs);
            viewModelInterfaces.AddFile("IMainViewModel")
                               .OfType(FileType.Cs);

            fileSystem.AddFolder("Models");

            IFolder themes = fileSystem.AddFolder("Themes");

            themes.AddFile("Brushes")
                  .OfType(FileType.Xaml);
            themes.AddFile("Images")
                  .OfType(FileType.Xaml);
            themes.AddFile("Styles")
                  .OfType(FileType.Xaml);

            fileSystem.AddFolder("Services");
            fileSystem.AddFolder("Helpers");
            fileSystem.AddFolder("Converters");
        }
    }
}