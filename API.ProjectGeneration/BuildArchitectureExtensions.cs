using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public static class BuildArchitectureExtensions
    {
        public static string AsPlatformString(this BuildArchitecture buildArchitecture)
        {
            return buildArchitecture.GetAttribute<PlatformStringAttribute>()
                                    .PlatformString;
        }
    }
}
