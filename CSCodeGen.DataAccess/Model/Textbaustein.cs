namespace CSCodeGen.DataAccess.Model
{
    public class Textbaustein
    {

        public string Key { get; set; }
        public string Value { get; set; }

        public Textbaustein(string value, string key)
        {
            this.Value = value;
            Key = key;
        }
    }
}
