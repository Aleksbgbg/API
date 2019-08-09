using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class SolutionTemplateReader : ITemplateReader
    {
        public string ReadTemplate(TemplateType templateType)
        {
            if (templateType == TemplateType.SolutionHeader)
            {
                return @"
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.29025.244
MinimumVisualStudioVersion = 10.0.40219.1
";
            }

            throw new NotSupportedException();
        }
    }
}
