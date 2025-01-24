using CSCodeGen.Library.Klassen.Template;
using CSCodeGen.Library.Klassen.Textbaustein;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Library.Controller
{
    public class TextbausteinController
    {
        public static BindingList<Textbaustein> textbausteine = new BindingList<Textbaustein>();
        public static void SaveTextbaustein()
        {
            var json = JsonConvert.SerializeObject(textbausteine);
            File.WriteAllText(Constants.GetDataPathTextbaustein(), json);
        }

        public static void LoadTextbausteine()
        {
            if (!File.Exists(Constants.GetDataPathTextbaustein())) textbausteine = new BindingList<Textbaustein>();
            var json = File.ReadAllText(Constants.GetDataPathTextbaustein());
            textbausteine = JsonConvert.DeserializeObject<BindingList<Textbaustein>>(json);
        }
    }
}
