namespace API.ProjectGeneration.Attributes
{
    using System;

    using API.ProjectGeneration.Models;

    [AttributeUsage(AttributeTargets.Field)]
    public class BuildArchitecturesAttribute : Attribute
    {
        public BuildArchitecturesAttribute(params BuildArchitecture[] buildArchitectures)
        {
            BuildArchitectures = buildArchitectures;
        }

        public BuildArchitecture[] BuildArchitectures { get; }
    }
}