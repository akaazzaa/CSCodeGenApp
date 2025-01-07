namespace CSCodeGen.Library
{
    public class Placeholder
    {
        public string Name { get; set; }
        public string DefaultValue { get; set; }

        public Placeholder(string name, string defaultValue = "")
        {
            Name = name;
            DefaultValue = defaultValue;
        }

        public override string ToString()
        {
            return $"<{Name}> = {DefaultValue}";
        }
    }
}
