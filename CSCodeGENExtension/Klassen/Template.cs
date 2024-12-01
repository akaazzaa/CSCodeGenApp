using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSCodeGENExtension.Klassen
{
    public class Template
    {

             private const string SEMIKOLON = ";";
             private const string KLAMMERAUF = "(";
             private const string KLAMMERZU = ")";

            public string ClassName { get; set; }

            public List<PropertyModel> Properties { get; set; }

            public string NamespaceName { get; set; } = "GeneratedNamespace";

            public List<MethodModel> Methods { get; set; }
            
            public Template() { }

       

    }
}
