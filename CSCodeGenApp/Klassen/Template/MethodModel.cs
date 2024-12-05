namespace CSCodeGenApp.Klassen.Template
{
    public class MethodModel
    {
        public string Zugriff { get; set; } = "public";
        public string Modifizierer { get; set; } = "staic";
        public string Rückgabewert { get; set; } = "void";
        public string Name { get; set; } = "GetAnzahl";

        private List<Parameter> Parameters { get; set; }

        public MethodModel()
        {

        }

        public void AddParameter(Parameter parameter)
        {
            Parameters.Add(parameter);
        }

    }
}
