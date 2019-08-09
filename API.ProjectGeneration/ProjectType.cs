using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public enum ProjectType
    {
        [BuildArchitectures(BuildArchitecture.AnyCPU)]
        [FileExtension("csproj")]
        Csharp,
        [BuildArchitectures(BuildArchitecture.x64, BuildArchitecture.x86)]
        [FileExtension("vcxproj")]
        Cpp
    }
}
