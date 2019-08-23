namespace API.ProjectGeneration.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    public class AsStringAttribute : Attribute
    {
        public AsStringAttribute(string stringRepresentation)
        {
            StringRepresentation = stringRepresentation;
        }

        public string StringRepresentation { get; }
    }
}