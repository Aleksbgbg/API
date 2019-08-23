namespace API.ProjectGeneration.Serialization
{
    using System.Text;

    using API.ProjectGeneration.Extensions;
    using API.ProjectGeneration.Models;

    public class ConfigurationSerializeable : ISerializeable
    {
        public ConfigurationSerializeable(BuildMode buildMode, BuildArchitecture buildArchitecture)
        {
            Mode = buildMode;
            Architecture = buildArchitecture;
        }

        public BuildMode Mode { get; }

        public BuildArchitecture Architecture { get; }

        public StringBuilder Serialize(StringBuilder into)
        {
            into.AppendFormat("{0}|{1} = {0}|{1}", Mode, Architecture.AsString());

            return into;
        }
    }
}