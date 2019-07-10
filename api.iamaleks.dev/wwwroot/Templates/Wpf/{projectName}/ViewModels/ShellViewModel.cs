namespace {projectName}.ViewModels
{
    using Caliburn.Micro;

    using {projectName}.ViewModels.Interfaces;

    public sealed class ShellViewModel : Conductor<IMainViewModel>, IShellViewModel
    {
        public ShellViewModel(IMainViewModel mainViewModel)
        {
            DisplayName = "{projectName}";

            ActivateItem(mainViewModel);
        }
    }
}