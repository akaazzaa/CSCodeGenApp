namespace CSCodeGen.Library
{
    public class Placeholder
    {
        public string Name { get; set; }
        public string value { get; set; }
        public string DefaultValue { get; set; }

        public Placeholder(string name, string defaultValue = "")
        {
            Name = name;
            DefaultValue = defaultValue;
            value = name;
        }

        public override string ToString()
        {
            return $"{DefaultValue}";
        }
    }
}
