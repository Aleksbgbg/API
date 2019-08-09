using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public static class GuidExtensions
    {
        public static string ToSolutionFormat(this Guid guid)
        {
            return guid.ToString()
                       .ToUpper();
        }
    }
}
