namespace API.ProjectGeneration.Projects.VisualStudio
{
    using System;
    using System.Collections.Generic;

    using API.ProjectGeneration.Extensions;
    using API.ProjectGeneration.Models;

    public class Project
    {
        public Project(string name, ProjectType projectType)
        {
            Guid = Guid.NewGuid();
            Name = name;
            ProjectType = projectType;
            BuildArchitectures = projectType.GetBuildArchitectures();
        }

        public Guid Guid { get; }

        public string Name { get; }

        public ProjectType ProjectType { get; }

        public IEnumerable<BuildArchitecture> BuildArchitectures { get; }
    }
}