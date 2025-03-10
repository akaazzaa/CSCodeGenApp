using CSCodeGen.Model.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Contracts.Args
{
    public class TemplateEventArgs : EventArgs
    {
        public CodeTemplate Template { get; set; } = null;

        public BindingList<CodeTemplate> Templates { get; set; } = null;

        public Keyword Keyword { get; set; } = null;

        public List<Keyword> Keywords { get; set; } = null;

        public TemplateEventArgs()
        {
            Templates = new BindingList<CodeTemplate>();
            Template = new CodeTemplate();
            Keywords = new List<Keyword>();
            Keyword = new Keyword();
        }



    }

}
