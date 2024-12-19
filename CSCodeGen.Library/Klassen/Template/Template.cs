﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CSCodeGen.Library.Klassen.Template
{
    public class Template
    {
        public string TemplateName { get; set; }
        public string ClassType { get; set; }

        public string AccessType { get; set; }
        public string ClassName { get; set; }

        public BindingList<PropertyModel> Properties { get; set; }

        public string NamespaceName { get; set; }

        public BindingList<MethodModel> Methods { get; set; }

        public string DisplayText
        {
            get
            {
                StringBuilder classBuilder = new StringBuilder();
                classBuilder.AppendLine("using System;");
                classBuilder.AppendLine($"namespace {NamespaceName}");
                classBuilder.AppendLine("{");
                classBuilder.AppendLine($"    {AccessType} {ClassType} {ClassName}");
                classBuilder.AppendLine("    {");

                foreach (var prop in Properties)
                {
                    classBuilder.AppendLine($"        {prop.AccessType} {prop.Type} {prop.Name} {{ get; set; }}");
                }

                classBuilder.AppendLine("    }");
                classBuilder.AppendLine("}");

                return classBuilder.ToString();
            }
            private set
            {

            }
        }

        public Template()
        {
            Methods = new BindingList<MethodModel>();
            Properties = new BindingList<PropertyModel>();

        }



    }
}
