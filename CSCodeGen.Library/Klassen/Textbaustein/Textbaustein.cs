namespace CSCodeGen.Library.Klassen.Textbaustein
{
    public class Textbaustein
    {
        private string _Text;

        public string Name
        {
            get { return _Text; }
            set { _Text = $"<#<{value}>#>"; }
        }

        public Textbaustein(string name)
        {
            Name = name;
        }
    }
}
