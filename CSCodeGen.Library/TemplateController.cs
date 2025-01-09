using System.Collections.Generic;

namespace CSCodeGen.Library
{
    public class TemplateController
    {
        private TemplateRepossitory TemplateRepossitory;

        public TemplateController()
        {
            TemplateRepossitory = new TemplateRepossitory();

        }

        public List<Template> Templates()
        {
            return TemplateRepossitory.GetAllTemplates();
        }

    }
}
