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
            RenderSolution(TemplateType.SolutionHeader);
        }

        private void RenderSolutionBody(Solution solution)
        {
            var allArchitectures = solution.Projects
                                           .SelectMany(project => project.BuildArchitectures)
                                           .Distinct();

            var serializable = new SerializeableSolution
            {
                Projects = solution.Projects.Select(project => new ProjectSerializable(project)),
                Sections = new GlobalSection[]
                    {
                        new GlobalSection(GlobalSectionName.SolutionConfigurationPlatforms, SolutionRelativePosition.PreSolution)
                        {
                             Entries = allArchitectures.SelectMany(ArchitectureConfigurations)
                                                       .OrderBy(config => config.Mode)
                                                       .Cast<ISerializeable>()
                                                       .ToArray()
                        },
                        new GlobalSection(GlobalSectionName.ProjectConfigurationPlatforms, SolutionRelativePosition.PostSolution)
                        {
                                Entries = solution.Projects
                                                  .SelectMany(project => ProjectConfigurations(project).OrderBy(config => config.Mode))
                                                  .Cast<ISerializeable>()
                                                  .ToArray()
                        },
                        new GlobalSection(GlobalSectionName.SolutionProperties, SolutionRelativePosition.PreSolution)
                        {
                                Entries = new ISerializeable[] { new BooleanKeySerializable("HideSolutionNode", false) }
                        },
                        new GlobalSection(GlobalSectionName.ExtensibilityGlobals, SolutionRelativePosition.PostSolution)
                        {
                                Entries = new ISerializeable[] { new GuidKeySerializeable("SolutionGuid", solution.Guid) }
                        }
                    }
            };

            foreach (var project in serializable.Projects)
            {
                project.Serialize(_stringBuilder);
            }

            _stringBuilder.AppendLine("Global");

            foreach (var section in serializable.Sections)
            {
                _stringBuilder.AppendFormat("\tGlobalSection({0}) = {1}", section.Name, section.Position.AsString());
                _stringBuilder.AppendLine();

                foreach (var entry in section.Entries)
                {
                    _stringBuilder.Append("\t\t");
                    entry.Serialize(_stringBuilder);
                    _stringBuilder.AppendLine();
                }

                _stringBuilder.AppendLine("\tEndGlobalSection");
            }

            _stringBuilder.AppendLine("EndGlobal");                                    
        }

        private void RenderSolutionEnd()
        {
            //RenderSolution(TemplateType.SolutionEnd);
        }

        private void RenderSolution(TemplateType templateType)
        {
            _stringBuilder.Append(_templateReader.ReadTemplate(templateType));
        }

        private IEnumerable<ConfigurationSerializeable> ArchitectureConfigurations(BuildArchitecture buildArchitecture)
        {
            yield return new ConfigurationSerializeable(BuildMode.Debug, buildArchitecture);
            yield return new ConfigurationSerializeable(BuildMode.Release, buildArchitecture);
        }

        private IEnumerable<ProjectConfigurationSerializable> ProjectConfigurations(Project project)
        {
            foreach (BuildMode buildMode in new BuildMode[] { BuildMode.Debug, BuildMode.Release })
            {
                foreach (BuildArchitecture buildArchitecture in project.BuildArchitectures)
                {
                    yield return new ProjectConfigurationSerializable(project.Guid, buildMode, buildArchitecture, BuildEntryType.ActiveCfg);
                    yield return new ProjectConfigurationSerializable(project.Guid, buildMode, buildArchitecture, BuildEntryType.Build0);
                }
            }
        }
    }
}
