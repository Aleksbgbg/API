namespace API.ProjectGeneration.Models
{
    using System;
    using System.Collections.Generic;

    using API.ProjectGeneration.Projects.VisualStudio;

    public class Solution
    {
        public Solution(IEnumerable<Project> projects)
        {
            Guid = Guid.NewGuid();
            Projects = projects;
        }

        public Guid Guid { get; }

        public IEnumerable<Project> Projects { get; }
    }
}