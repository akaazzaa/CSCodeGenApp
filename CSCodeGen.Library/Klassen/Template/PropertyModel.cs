namespace CSCodeGen.Library.Klassen.Template
{
    public class PropertyModel
    {
        public string AccessType { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public string DisplayText
        {
            get
            {
                return string.Empty;
            }
            private set
            {

            }
        }
    }
}
