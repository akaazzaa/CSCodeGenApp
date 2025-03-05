using CSCodeGen.DataAccess.Model.Main;
using System.Collections.Generic;

namespace CSCodeGen.DataAccess.Model.Klasse
{
    public class GenerationContext
    {
        public CodeTemplate Template { get; set; }
        public string ClassName { get; set; }
        public string NameSpace { get; set; }
        public List<PropertyDefinition> Properties { get; set; }
        public List<VariableDefinition> Variables { get; set; }

    }
}
