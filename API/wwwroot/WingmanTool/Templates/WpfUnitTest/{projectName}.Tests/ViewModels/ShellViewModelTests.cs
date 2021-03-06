﻿namespace {projectNamespace}.Tests.ViewModels
{
    using Moq;

    using {projectNamespace}.ViewModels;
    using {projectNamespace}.ViewModels.Interfaces;

    using Xunit;

    public class ShellViewModelTests
    {
        private readonly Mock<IMainViewModel> _mainViewModelMock;

        private readonly ShellViewModel _shellViewModel;

        public ShellViewModelTests()
        {
            _mainViewModelMock = new Mock<IMainViewModel>();

            _shellViewModel = new ShellViewModel(_mainViewModelMock.Object);
        }

        [Fact]
        public void TestDisplayName()
        {
            Assert.Equal("{projectName}", _shellViewModel.DisplayName);
        }
    }
}