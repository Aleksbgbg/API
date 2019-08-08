using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class Solution
    {
        public Solution(IEnumerable<Project> projects)
        {
            Guid = Guid.NewGuid();
            Projects = projects;
        }

        public Guid Guid { get; }

        public IEnumerable<Project> Projects { get; }
    }
}
