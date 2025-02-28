namespace CSCodeGen.DataAccess.Model.Klasse
{
    public class Propertie
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public bool isUsed { get; set; }

        public Propertie()
        {
            Name = string.Empty;
            DataType = string.Empty;
        }
    }
}
