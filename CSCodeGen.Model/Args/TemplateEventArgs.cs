using CSCodeGen.Model.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Model.Args
{
    public class TemplateEventArgs : EventArgs
    {
        public Template Template { get; set; } = null;

        public BindingList<Template> Templates { get; set; } = null;

        public Textbaustein Keyword { get; set; } = null;

        public List<Textbaustein> Keywords { get; set; } = null;

        public object Undefined { get; set; } = null;

   
    }

}
