namespace CSCodeGen.Library
{
    public class Placeholder
    {
        public PlaceholderType Type { get; set; }
        public string Name { get; set; } // Platzhalter-Name, z. B. "classname"
        public string Value { get; set; } // Dynamischer Wert des Platzhalters

        public Placeholder(PlaceholderType type, string name, string value = "")
        {
            Type = type;
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return $"<{Name}> = {Value}";
        }
    }


}
