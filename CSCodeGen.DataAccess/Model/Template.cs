namespace CSCodeGen.DataAccess.Model
{
    public class Template
    {
        public string Name { get; set; }
        public string Content { get; set; }

        public Template()
        {
            Content = string.IsNullOrWhiteSpace(Content)
                ? "namespace {Namespace}\r\n{\r\n    {ClassModifier} class {ClassName}\r\n    {\r\n        {Members}\r\n    }\r\n}"
                : Content;
        }
    }
}
