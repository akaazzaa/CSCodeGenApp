
using CSCodeGen.Library;

namespace CSCodeGen.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemplateManager templateManager = new TemplateManager();

            // Schritt 1: Erstelle ein Template mit Placeholdern
            var placeholders = new List<Placeholder>
        {
            new Placeholder("namespace", "MyNamespace"),
            new Placeholder("classname", "MyClass"),
            new Placeholder("methodname", "MyMethod")
        };
            templateManager.CreateTemplate("MyTemplate", placeholders);

            // Schritt 2: Lade und zeige das Template
            Console.WriteLine("Template:");
            string template = templateManager.LoadTemplate("MyTemplate");
            Console.WriteLine(template);

            // Schritt 3: Ersetze Placeholder und zeige das Ergebnis
            var values = new Dictionary<string, string>
        {
            { "namespace", "ExampleNamespace" },
            { "classname", "ExampleClass" },
            { "methodname", "ExampleMethod" }
        };
            string filledTemplate = templateManager.FillTemplate("MyTemplate", values);
            Console.WriteLine("\nTemplate nach dem Ersetzen:");
            Console.WriteLine(filledTemplate);
        }
    }
}


