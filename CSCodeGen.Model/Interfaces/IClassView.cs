using CSCodeGen.Model.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Model.Interfaces
{
    public interface IClassView
    {
        event EventHandler LoadTemplates;



        void ShowTemplates(BindingList<Template> templates);
        void ShowMessage(string message);
    }
}
