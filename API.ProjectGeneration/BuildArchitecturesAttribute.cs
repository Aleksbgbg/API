using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class BuildArchitecturesAttribute : Attribute
    {
        public BuildArchitecturesAttribute(params BuildArchitecture[] buildArchitectures)
        {
            BuildArchitectures = buildArchitectures;
        }

        public BuildArchitecture[] BuildArchitectures { get; }
    }
}
