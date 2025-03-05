//using CodeGeneratorTester.Keyword;

//namespace CodeGeneratorTester
//{
//    public class CodeGenerationService
//    {
//        public string GenerateCode(CodeTemplate template, GenerationContext context)
//        {
//            string generatedCode = template.TemplateContent;

//            // Ersetze Systemstandard-Keywords
//            generatedCode = ReplaceSystemKeywords(generatedCode, context);

//            // Ersetze benutzerdefinierte Keywords
//            generatedCode = ReplaceUserDefinedKeywords(generatedCode, context);

//            // Ersetze Eigenschaften
//            generatedCode = ReplaceProperties(generatedCode, context.Properties);

//            // Ersetze Variablen
//            generatedCode = ReplaceVariables(generatedCode, context.Variables);

//            return generatedCode;
//        }

//        private string ReplaceSystemKeywords(string code, GenerationContext context)
//        {
//            // Standardersetzungen wie Klassenname
//            return code.Replace("<#Classname#>", context.ClassName);
//        }

//        private string ReplaceUserDefinedKeywords(string code, GenerationContext context)
//        {
//            foreach (var keyword in context.Template.Keywords)
//            {
//                if (keyword.Type == KeywordType.UserDefined)
//                {
//                    code = code.Replace(keyword.Placeholder, keyword.DefaultCode);
//                }
//            }
//            return code;
//        }

//        private string ReplaceProperties(string code, List<PropertyDefinition> properties)
//        {
//            var propertyTemplate = FindKeywordTemplate(code, "//<#AddPropertie#>");
//            if (propertyTemplate == null) return code;

//            var generatedProperties = properties.Select(prop =>
//                propertyTemplate.Replace("<#PropertyType#>", prop.Type)
//                                .Replace("<#PropertyName#>", prop.Name)
//            ).ToList();

//            return code.Replace(propertyTemplate, string.Join(Environment.NewLine, generatedProperties));
//        }

//        private string ReplaceVariables(string code, List<VariableDefinition> variables)
//        {
//            var variableTemplate = FindKeywordTemplate(code, "//<#AddVar#>");
//            if (variableTemplate == null) return code;

//            var generatedVariables = variables.Select(var =>
//                variableTemplate.Replace("<#VariableType#>", var.Type)
//                                .Replace("<#VariableName#>", var.Name)
//            ).ToList();

//            return code.Replace(variableTemplate, string.Join(Environment.NewLine, generatedVariables));
//        }
//    }

//    public class GenerationContext
//    {
//        public CodeTemplate Template { get; set; }
//        public string ClassName { get; set; }
//        public List<PropertyDefinition> Properties { get; set; }
//        public List<VariableDefinition> Variables { get; set; }
//    }

//    public class PropertyDefinition
//    {
//        public string Name { get; set; }
//        public string Type { get; set; }
//    }

//    public class VariableDefinition
//    {
//        public string Name { get; set; }
//        public string Type { get; set; }
//    }
//}
