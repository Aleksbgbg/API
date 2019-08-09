using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class PlatformStringAttribute : Attribute
    {
        public string PlatformString { get; }

        public PlatformStringAttribute(string platformString)
        {
            PlatformString = platformString;
        }
    }
}
