using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGENExtension.Klassen
{
   public class MethodModel
    {
        public string Zugriff {  get; set; }
        public string Modifizierer { get; set; }
        public string Name { get; set; }

       private  List<Parameter> Parameters { get; set; }

        public MethodModel() 
        {
            
        }

        public void AddParameter(Parameter parameter)
        {
            Parameters.Add(parameter);
        }

    }
}
