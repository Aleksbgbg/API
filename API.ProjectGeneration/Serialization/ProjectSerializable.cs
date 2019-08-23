namespace API.ProjectGeneration.Serialization
{
    using System;
    using System.Text;

    using API.ProjectGeneration.Extensions;
    using API.ProjectGeneration.Projects.VisualStudio;

    public class ProjectSerializable : ISerializeable
    {
        private readonly Project _project;

        public ProjectSerializable(Project project)
        {
            _project = project;
        }

        public StringBuilder Serialize(StringBuilder into)
        {
            into.AppendFormat("Project(\"{{{0}}}\") = \"{1}\", \"{1}\\{1}.{2}\", \"{{{3}}}\"", Guid.NewGuid().ToUpper(), _project.Name, _project.ProjectType.GetFileExtension(), _project.Guid.ToUpper());
            into.AppendLine();
            into.AppendLine("EndProject");
            return into;
        }
    }
}