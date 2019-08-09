using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class GlobalSection
    {
        public GlobalSection(GlobalSectionName name, SolutionRelativePosition position)
        {
            Name = name;
            Position = position;
        }

        public GlobalSectionName Name { get; }

        public SolutionRelativePosition Position { get; }

        public ISerializeable[] Entries { get; set; }
    }
}
