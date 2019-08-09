using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class SerializeableSolution
    {
        public IEnumerable<ProjectSerializable> Projects { get; set; }

        public GlobalSection[] Sections { get; set; }
    }
}
