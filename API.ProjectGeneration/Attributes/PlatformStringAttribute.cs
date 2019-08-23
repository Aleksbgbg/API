namespace API.ProjectGeneration.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    public class PlatformStringAttribute : Attribute
    {
        public PlatformStringAttribute(string platformString)
        {
            PlatformString = platformString;
        }

        public string PlatformString { get; }
    }
}