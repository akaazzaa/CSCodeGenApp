using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Model.Main
{
    public class GeneratorUIData
    {
        public string ClassName { get; set; } = string.Empty;
        public string? NameSpace { get; set; } = string.Empty;
        public BindingList<UserValue> UserValues { get; set; } = new BindingList<UserValue>();

    }
}
