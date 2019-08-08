using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
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
