using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class ConfigurationSerializeable : ISerializeable
    {
        public BuildMode Mode { get; }

        public BuildArchitecture Architecture { get; }

        public ConfigurationSerializeable(BuildMode buildMode, BuildArchitecture buildArchitecture)
        {
            Mode = buildMode;
            Architecture = buildArchitecture;
        }

        public StringBuilder Serialize(StringBuilder into)
        {
            into.AppendFormat("{0}|{1} = {0}|{1}",
                              Mode,
                              Architecture.AsString());

            return into;
        }
    }
}
