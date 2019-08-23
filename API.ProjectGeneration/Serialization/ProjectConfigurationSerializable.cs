namespace API.ProjectGeneration.Serialization
{
    using System;
    using System.Text;

    using API.ProjectGeneration.Extensions;
    using API.ProjectGeneration.Models;

    public class ProjectConfigurationSerializable : ISerializeable
    {
        private readonly Guid _projectGuid;

        private readonly BuildEntryType _buildEntryType;

        public ProjectConfigurationSerializable(Guid projectGuid, BuildMode buildMode, BuildArchitecture buildArchitecture, BuildEntryType buildEntryType)
        {
            _projectGuid = projectGuid;
            Mode = buildMode;
            Architecture = buildArchitecture;
            _buildEntryType = buildEntryType;
        }

        public BuildMode Mode { get; }

        public BuildArchitecture Architecture { get; }

        public StringBuilder Serialize(StringBuilder into)
        {
            into.AppendFormat("{{{0}}}.{1}|{2}.{3} = {1}|{4}", _projectGuid.ToUpper(), Mode, Architecture.AsString(), _buildEntryType.AsString(), Architecture.AsPlatformString());
            return into;
        }
    }
}