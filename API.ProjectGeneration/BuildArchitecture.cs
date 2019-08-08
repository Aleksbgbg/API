using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public enum BuildArchitecture
    {
        [ToString("x86")]
        x86,
        [ToString("x64")]
        x64,
        [ToString("Any CPU")]
        AnyCPU
    }
}
