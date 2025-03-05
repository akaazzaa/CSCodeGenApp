namespace CSCodeGen.DataAccess.Model.Klasse
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