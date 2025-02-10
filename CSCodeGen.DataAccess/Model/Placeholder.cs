namespace CSCodeGen.DataAccess.Model
{
    public class Placeholder
    {
        public string Name { get; set; }
        public string DefaultValue { get; set; }
        public string SwitchPoint { get; set; }

        // Konstruktor
        public Placeholder(string name, string defaultValue = "", string switchPoint = "")
        {
            Name = name;
            DefaultValue = defaultValue;
            SwitchPoint = switchPoint;
        }

        public override string ToString()
        {
            return $"{Name} (Default: {DefaultValue}, SwitchPoint: {SwitchPoint})";
        }
    }
}
