namespace CSCodeGen.Model.Model
{
    public class VariableDefinition
    {
        public string Name { get; set; }
        public string DataType { get; set; }

        public VariableDefinition()
        {
            Name = string.Empty;
            DataType = string.Empty;
        }
    }
}