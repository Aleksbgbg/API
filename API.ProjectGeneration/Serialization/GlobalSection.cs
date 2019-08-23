namespace API.ProjectGeneration.Serialization
{
    using API.ProjectGeneration.Models;

    public class GlobalSection
    {
        public GlobalSection(GlobalSectionName name, SolutionRelativePosition position)
        {
            Name = name;
            Position = position;
        }

        public GlobalSectionName Name { get; }

        public SolutionRelativePosition Position { get; }

        public ISerializeable[] Entries { get; set; }
    }
}