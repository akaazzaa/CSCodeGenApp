namespace CSCodeGen.Library.Klassen.Template
{
    public class MethodModel
    {
        public string AccessType { get; set; }
        public string Modifizierer { get; set; }
        public string Rückgabewert { get; set; }
        public string Name { get; set; }
        public string Displaytext
        {
            get { return string.Empty; }
            private set { }
        }


        public MethodModel()
        {

        }



    }
}
