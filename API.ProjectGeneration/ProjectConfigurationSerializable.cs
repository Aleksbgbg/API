using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class ProjectConfigurationSerializable : ISerializeable
    {
        private readonly Guid _projectGuid;

        public BuildMode Mode { get; }

        public BuildArchitecture Architecture { get; }

        private readonly BuildEntryType _buildEntryType;

        public ProjectConfigurationSerializable(Guid projectGuid, BuildMode buildMode, BuildArchitecture buildArchitecture, BuildEntryType buildEntryType)
        {
            _projectGuid = projectGuid;
            Mode = buildMode;
            Architecture = buildArchitecture;
            _buildEntryType = buildEntryType;
        }

        public StringBuilder Serialize(StringBuilder @into)
        {
            into.AppendFormat("{{{0}}}.{1}|{2}.{3} = {1}|{4}", _projectGuid.ToSolutionFormat(), Mode, Architecture.AsString(), _buildEntryType.AsString(), Architecture.AsPlatformString());
            return into;
        }
    }
}
