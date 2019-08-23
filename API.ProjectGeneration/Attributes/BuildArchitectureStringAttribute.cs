namespace API.ProjectGeneration.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    public class BuildArchitectureStringAttribute : Attribute
    {
        public BuildArchitectureStringAttribute(string buildArchitectureString)
        {
            BuildArchitectureString = buildArchitectureString;
        }

        public string BuildArchitectureString { get; }
    }
}