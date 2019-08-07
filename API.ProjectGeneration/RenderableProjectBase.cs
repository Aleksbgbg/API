namespace API.ProjectGeneration
{
    public class RenderableProjectBase : IRenderableProject
    {
        private readonly FileSystemSnapshot _systemSnapshot;

        public RenderableProjectBase(string name)
        {
            Name = name;
            _systemSnapshot = new FileSystemSnapshot();
            FileSystem = new FileSystem(name, _systemSnapshot);
        }

        protected string Name { get; }

        protected FileSystem FileSystem { get; }

        public FileSystemSnapshot Render()
        {
            FileSystem.AddFile(Name)
                      .OfType(FileType.Csproj);

            AddCustomFiles(FileSystem);

            return _systemSnapshot;
        }

        private protected virtual void AddCustomFiles(IFileSystem fileSystem)
        {
        }
    }
}