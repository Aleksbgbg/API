using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class ProjectSerializable : ISerializeable
    {
        private readonly Project _project;
        
        public ProjectSerializable(Project project)
        {
            _project = project;
        }

        public StringBuilder Serialize(StringBuilder @into)
        {
            into.AppendFormat("Project(\"{{{0}}}\") = \"{1}\", \"{1}\\{1}.{2}\", \"{{{3}}}\"", Guid.NewGuid().ToSolutionFormat(), _project.Name, _project.ProjectType.GetFileExtension(), _project.Guid.ToSolutionFormat());
            into.AppendLine();
            into.AppendLine("EndProject");
            return into;
        }
    }
}
