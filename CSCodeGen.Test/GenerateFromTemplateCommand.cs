namespace CSCodeGen.Test
{
    public class GenerateFromTemplateCommand : ICommand
    {
        private readonly TemplateManager templateManager;

        public GenerateFromTemplateCommand(TemplateManager templateManager)
        {
            this.templateManager = templateManager;
        }

        public string Name => "generate-template";
        public string Description => "Generiert eine Datei basierend auf einem spezifischen Template.";

        public void Execute(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Verwendung: generate-template <templateName> <outputName> [namespace]");
                return;
            }

            string templateName = args[0];
            string outputName = args[1];
            string namespaceName = args.Length > 2 ? args[2] : "DefaultNamespace";

            try
            {
                // Template laden
                string template = templateManager.LoadTemplate(templateName);




                string filledTemplate = templateManager.FillTemplate(template);

                // Datei speichern
                File.WriteAllText(outputName, filledTemplate);
                Console.WriteLine($"Datei '{outputName}' wurde erfolgreich generiert.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
        }
    }
}
