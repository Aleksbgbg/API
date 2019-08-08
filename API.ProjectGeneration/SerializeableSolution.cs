using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class SerializeableSolution
    {
        public IEnumerable<Project> Projects { get; set; }

        public IEnumerable<GlobalSection> Sections { get; set; }
    }
}
