using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Library.Controller
{
    public class Constants
    {
        private static string dataPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Templates";
        private const string templateDataName = "Templates.json";
        private const string textbausteinDataName = "Textbaustein.json";

        public static string GetDataPathTemplate()
        {
            var path = Path.Combine(dataPath, templateDataName);
            return path;
        }

        public static string GetDataPathTextbaustein()
        {
            var path = Path.Combine(dataPath, textbausteinDataName);
            return path;
        }
    }
}
