namespace CSCodeGenApp.Klassen.Template
{
    public class Template
    {

        public string ClassName { get; set; } 

        public List<PropertyModel> Properties { get; set; } = new();

        public string NamespaceName { get; set; } 

        public List<MethodModel> Methods { get; set; } = new();

        public Template()
        {

        }




    }
}
