using System.ComponentModel;

namespace CSCodeGen.Library.Klassen.Template
{
    public interface ITemplate
    {
        string TemplateName { get; set; }
        string ClassType { get; set; }

        string AccessType { get; set; }
        string ClassName { get; set; }

        BindingList<PropertyModel> Properties { get; set; }

        string NamespaceName { get; set; }

        BindingList<MethodModel> Methods { get; set; }
    }
}
