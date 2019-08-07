namespace API.ProjectGeneration
{
    using System;

    public interface IConfigurableFileSystemProject<T>
    {
        T ConfigureFileSystem(Action<IFileSystem> configuration);
    }
}