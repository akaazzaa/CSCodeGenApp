using CSCodeGen.Model.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Model.Interfaces
{
     public interface IClassRepository
    {
        BindingList<Template> GetTemplates();
        void Add(Template obj);
        void Save(Template obj);
        void SaveAll();
        void LoadAll();
    }
}
