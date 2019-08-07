namespace API.ProjectGeneration
{
    using System;
    using System.Collections.Generic;

    public class VisualStudioSolution : IVisualStudioSolution
    {
        private readonly string _name;

        private readonly List<IRenderableProject> _projects = new List<IRenderableProject>();

        public VisualStudioSolution(string name)
        {
            _name = name;
        }

        public FileSystemSnapshot Render()
        {
            FileSystemSnapshot snapshot = new FileSystemSnapshot();

            snapshot.Add(new FileSystemEntry($"{_name}.sln", false));

            foreach (IRenderableProject project in _projects)
            {
                foreach (FileSystemEntry fileSystemEntry in project.Render().Entries)
                {
                    snapshot.Add(fileSystemEntry);
                }
            }

            return snapshot;
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