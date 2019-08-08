using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class BuildArchitectureStringAttribute : Attribute
    {
        public BuildArchitectureStringAttribute(string buildArchitectureString)
        {
            BuildArchitectureString = buildArchitectureString;
        }

        public string BuildArchitectureString { get; }
    }
}
