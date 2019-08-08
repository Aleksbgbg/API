using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class SectionEntry
    {
        public SectionEntry(ISerializeable entry)
        {
            Key = entry;
            Value = entry;
        }

        public SectionEntry(ISerializeable key, ISerializeable value)
        {
            Key = key;
            Value = value;
        }

        public ISerializeable Key { get; }

        public ISerializeable Value { get; }
    }
}
