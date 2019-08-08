using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public static class SolutionRelativePositionExtensions
    {
        public static string AsString(this SolutionRelativePosition solutionRelativePosition)
        {
            return solutionRelativePosition.GetAttribute<ToStringAttribute>()
                                           .StringRepresentation;
        }
    }
}
