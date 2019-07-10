namespace {projectName}
{
    using {projectName}.ViewModels.Interfaces;
    using {projectName}.ViewModels;

    using Wingman.Bootstrapper;
    using Wingman.Container;

    public class AppBootstrapper : BootstrapperBase<IShellViewModel>
    {
        protected override void RegisterViewModels(IDependencyRegistrar dependencyRegistrar)
        {
            dependencyRegistrar.Singleton<IShellViewModel, ShellViewModel>();
            dependencyRegistrar.Singleton<IMainViewModel, MainViewModel>();
        }
    }
}