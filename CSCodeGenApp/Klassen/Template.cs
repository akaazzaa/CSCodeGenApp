namespace CSCodeGENExtension.Klassen
{
    public class Template
    {



        public string ClassName { get; set; } = "public";

        public List<PropertyModel> Properties { get; set; } = new();

        public string NamespaceName { get; set; } = "GeneratedNamespace";

        public List<MethodModel> Methods { get; set; } = new();

        public Template()
        {

        }




    }
}
