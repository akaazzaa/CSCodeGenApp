
using CSCodeGen.Model.Main;
using System.Collections.Generic;

namespace CSCodeGen.Model.Model
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
