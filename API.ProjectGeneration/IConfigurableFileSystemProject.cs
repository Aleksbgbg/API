namespace API.ProjectGeneration
{
    using System;

    public interface IConfigurableFileSystemProject<T>
    {
        T ConfigureProjectRoot(Action<IFolder> projectRootConfiguration);
    }
}