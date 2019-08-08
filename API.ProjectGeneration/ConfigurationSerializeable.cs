using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class ConfigurationSerializeable : ISerializeable
    {
        private readonly BuildMode _buildMode;

        private readonly BuildArchitecture _buildArchitecture;

        public ConfigurationSerializeable(BuildMode buildMode, BuildArchitecture buildArchitecture)
        {
            _buildMode = buildMode;
            _buildArchitecture = buildArchitecture;
        }

        public StringBuilder Serialize(StringBuilder into)
        {
            into.AppendFormat("{0}|{1}",
                              _buildMode.ToString(),
                              _buildArchitecture.GetAttribute<ToStringAttribute>()
                                                .StringRepresentation);

            return into;
        }
    }
}
