using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public static class ProjectTypeExtensions
    {
        public static BuildArchitecture[] GetBuildArchitectures(this ProjectType projectType)
        {
            return projectType.GetAttribute<BuildArchitecturesAttribute>()
                              .BuildArchitectures;
        }

        public static string GetFileExtension(this ProjectType projectType)
        {
            return projectType.GetAttribute<FileExtensionAttribute>()
                              .FileExtension;
        }
    }
}
