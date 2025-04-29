using CSCodeGen.Model.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Model.Args
{
    public class GeneratorEventArgs
    {
        public string? ClassName { get; set; } = null;
        public string? Namespace { get; set; } = null;
        public string? ContentResult { get; set; } = null;
        public string TemplateName { get; set; } = string.Empty;
        public BindingList<UserValue>? UserValues { get; set; } = null;
    }
}
