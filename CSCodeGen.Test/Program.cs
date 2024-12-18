using CSCodeGen.Library.Klassen.Template;

namespace CSCodeGen.Test
{
    internal class Program
    {
        static List<Template> templates;
        static void Main(string[] args)
        {
            templates = new List<Template>();
            Template test = new Template()
            {
                TemplateName = "test",
                AccessType = "public",
                ClassType = "class",
                ClassName = "Tester",
                NamespaceName = "Template.Test",
                Properties = { new PropertyModel { AccessType = "public", Name = "Alter", Type = "int" } },
                Methods = { new MethodModel { AccessType = "private", Modifizierer = string.Empty, Name = "GetTest", Rückgabewert = "string" } }
            };


            templates.Add(test);
            templates.Add(test);
            templates.Add(test);
            templates.Add(test);
            templates.Add(test);


            foreach (Template template in templates)
            {
                Console.WriteLine(template.DisplayText);
            }
        }
    }
}
