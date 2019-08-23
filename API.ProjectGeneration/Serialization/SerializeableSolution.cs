namespace API.ProjectGeneration.Serialization
{
    using System.Collections.Generic;

    public class SerializeableSolution
    {
        public IEnumerable<ProjectSerializable> Projects { get; set; }

        public GlobalSection[] Sections { get; set; }
    }
}