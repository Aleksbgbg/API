namespace API.ProjectGeneration.Projects
{
    using System;

    using API.ProjectGeneration.FileSystem;

    public interface IConfigurableFileSystemProject<T>
    {
        T ConfigureProjectRoot(Action<IFolder> projectRootConfiguration);
    }
}