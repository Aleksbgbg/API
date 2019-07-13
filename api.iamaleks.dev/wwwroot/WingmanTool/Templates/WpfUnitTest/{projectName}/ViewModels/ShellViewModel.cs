namespace {projectNamespace}.ViewModels
{
    using Caliburn.Micro;

    using {projectNamespace}.ViewModels.Interfaces;

    public sealed class ShellViewModel : Conductor<IMainViewModel>, IShellViewModel
    {
        public ShellViewModel(IMainViewModel mainViewModel)
        {
            DisplayName = "{projectName}";

            ActivateItem(mainViewModel);
        }
    }
}