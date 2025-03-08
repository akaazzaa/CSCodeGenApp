namespace CSCodeGen.Model.Model
{
    public class PropertyDefinition
    {
        public string Name { get; set; }
        public string DataType { get; set; }

        public PropertyDefinition()
        {
            Name = string.Empty;
            DataType = string.Empty;
        }
    }
}
