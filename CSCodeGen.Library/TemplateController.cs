

using CSCodeGen.DataAccess.Model;
using CSCodeGen.DataAccess.Repository;
using System.Collections.Generic;
using System.ComponentModel;

namespace CSCodeGen.Library
{
    public class TemplateController 
    {
        private TemplateRepossitory repository;
        public TemplateController(TemplateRepossitory repossitory)
        {
            this.repository = repossitory;
        }

        public BindingList<Template> GetTemplateList()
        {
            return repository.GetAll();
        }
        public void Add(Template template)
        {
            repository.Add(template);
        }

        public void Remove(Template template)
        {
            repository.Remove(template);
        }

        public virtual void Save() => repository.Save();

    }
}
