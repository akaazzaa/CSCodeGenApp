using System.Collections.Generic;

namespace CSCodeGen.Library
{
    public class TemplateRepossitory
    {
        public List<Template> GetAllTemplates()
        {
            List<Template> templates = new List<Template>();

            for (int i = 0; i < 20; i++)
            {
                Template template = new Template();
                template.Name = $"Test{i}";
                template.Content = $"faifhaifafaifalfnlafafafhipfhapfhapifhff{i}";
                templates.Add(template);
            }

            return templates;
        }
    }
}
