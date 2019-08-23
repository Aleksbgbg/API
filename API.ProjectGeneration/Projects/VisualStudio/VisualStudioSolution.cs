namespace API.ProjectGeneration.Projects.VisualStudio
{
    using System;
    using System.Collections.Generic;

    using API.ProjectGeneration.FileSystem;
    using API.ProjectGeneration.Models;
    using API.ProjectGeneration.Projects.VisualStudio.Cpp;
    using API.ProjectGeneration.Projects.VisualStudio.Cs;

    public class VisualStudioSolution : IVisualStudioSolution
    {
        private readonly string _name;

        private readonly FileSystemSnapshot _systemSnapshot;

        private readonly IFileSystem _fileSystem;

        private readonly List<IRenderableProject> _projects;

        public VisualStudioSolution(string name)
        {
            _name = name;
            _systemSnapshot = new FileSystemSnapshot();
            _fileSystem = new FileSystem(name, _systemSnapshot);
            _projects = new List<IRenderableProject>();
        }

        public FileSystemSnapshot Render()
        {
            _fileSystem.AddFile(_name).OfType(FileType.Sln);

            foreach (IRenderableProject project in _projects)
            {
                IFolder projectRoot = _fileSystem.AddFolder(project.Name);
                project.Render(projectRoot);
            }

            return _systemSnapshot;
        }

        public ICppProject AddCppProject()
        {
            throw new NotImplementedException();
        }

        public ICsharpProject AddCsharpProject(string name)
        {
            CsharpProject csharpProject = new CsharpProject(name);
            _projects.Add(csharpProject);
            return csharpProject;
        }
    }
}