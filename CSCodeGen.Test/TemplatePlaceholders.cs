namespace CSCodeGen.Test
{
    public class TemplatePlaceholders
    {
        private readonly Dictionary<string, string> placeholders;

        public TemplatePlaceholders()
        {
            placeholders = new Dictionary<string, string>();
        }

        // Füge Platzhalter hinzu
        public void AddPlaceholder(string key, string value)
        {
            if (placeholders.ContainsKey(key))
            {
                placeholders[key] = value; // Ersetze bestehenden Wert
            }
            else
            {
                placeholders.Add(key, value); // Neuer Platzhalter
            }
        }

        // Entferne Platzhalter
        public void RemovePlaceholder(string key)
        {
            placeholders.Remove(key);
        }

        // Ersetze Platzhalter im Template
        public string ReplacePlaceholders(string template)
        {
            foreach (var placeholder in placeholders)
            {
                string placeholderKey = $"<#prefab.{placeholder.Key}#>";
                template = template.Replace(placeholderKey, placeholder.Value);
            }

            return template;
        }

        // Holen Sie sich alle Platzhalter als Dictionary
        public Dictionary<string, string> GetPlaceholders()
        {
            return new Dictionary<string, string>(placeholders);
        }
    }
}
