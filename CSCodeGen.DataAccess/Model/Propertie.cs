namespace CSCodeGen.DataAccess.Model
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
