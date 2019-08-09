using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public enum BuildEntryType
    {
        [ToString("ActiveCfg")]
        ActiveCfg,
        [ToString("Build.0")]
        Build0
    }
}
