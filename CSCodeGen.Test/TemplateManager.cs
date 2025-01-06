namespace CSCodeGen.Test
{
    public class TemplateManager
    {
        private readonly string templateDirectory;
        private readonly TemplatePlaceholders placeholders;

        public TemplateManager(string templateDirectory)
        {
            this.templateDirectory = templateDirectory;
            this.placeholders = new TemplatePlaceholders();
        }

        public string LoadTemplate(string templateName)
        {
            string templatePath = Path.Combine(templateDirectory, $"{templateName}.txt");

            if (!File.Exists(templatePath))
            {
                throw new FileNotFoundException($"Template '{templateName}' wurde nicht gefunden.");
            }

            return File.ReadAllText(templatePath);
        }

        public string FillTemplate(string template)
        {
            return placeholders.ReplacePlaceholders(template);
        }

        public void AddPlaceholder(string key, string value)
        {
            placeholders.AddPlaceholder(key, value);
        }

        public void RemovePlaceholder(string key)
        {
            placeholders.RemovePlaceholder(key);
        }

        public Dictionary<string, string> GetPlaceholders()
        {
            return placeholders.GetPlaceholders();
        }
    }
}
