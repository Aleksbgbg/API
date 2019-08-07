namespace API.ProjectGeneration
{
    using System;

    public class ConsoleProject : RenderableProjectBase, IConsoleProject
    {
        public ConsoleProject(string name) : base(name)
        {
        }

        public IConsoleProject ConfigureFileSystem(Action<IFileSystem> configuration)
        {
            configuration(FileSystem);
            return this;
        }

        private protected override void AddCustomFiles(IFileSystem fileSystem)
        {
            fileSystem.AddFile("Program")
                      .OfType(FileType.Cs);
        }
    }
}