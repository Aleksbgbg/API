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
        [BuildArchitectures(BuildArchitecture.x86, BuildArchitecture.x64)]
        [FileExtension("vcxproj")]
        Cpp
    }
}
