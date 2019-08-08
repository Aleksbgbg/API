using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class SolutionFileRenderer : IFileRenderer<Solution>
    {
        private readonly ITemplateReader _templateReader;

        private readonly StringBuilder _stringBuilder;

        public SolutionFileRenderer(ITemplateReader templateReader)
        {
            _templateReader = templateReader;
            _stringBuilder = new StringBuilder();
        }

        public string Render(Solution model)
        {
            RenderSolutionStart();
            RenderSolutionBody(model);
            RenderSolutionEnd();

            string result = _stringBuilder.ToString();
            _stringBuilder.Clear();
            return result;
        }

        private void RenderSolutionStart()
        {
            RenderSolution(TemplateType.SolutionStart);
        }

        private void RenderSolutionBody(Solution solution)
        {
            new SerializeableSolution
            {
                Projects = solution.Projects,
                Sections =
                    {
                        new GlobalSection(GlobalSectionName.SolutionConfigurationPlatforms, SolutionRelativePosition.PreSolution)
                        {
                             Entries =
                             {
                                     new ConfigurationSerializeable(BuildMode.Debug, BuildArchitecture.AnyCPU)
                             }
                        }
                    }
            };

            foreach (Project project in solution.Projects)
            {
                _stringBuilder.AppendFormat("Project(\"{0}\") = \"{1}\", \"{1}\\{1}.{2}\", \"{3}\"", Guid.NewGuid(), project.Name, project.ProjectType.GetFileExtension(), project.Guid);
                _stringBuilder.AppendLine();
                _stringBuilder.AppendLine("EndProject");
            }

            _stringBuilder.AppendLine("Global");
        }

        private void RenderSolutionEnd()
        {
            RenderSolution(TemplateType.SolutionEnd);
        }

        private void RenderSolution(TemplateType templateType)
        {
            _stringBuilder.Append(_templateReader.ReadTemplate(templateType));
        }
    }
}
