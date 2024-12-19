using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSCodeGen.Library.Klassen.CSDatei
{
    public class Datei
    {
        private string name;
        private string text;

        private const string DateiTyp = ".cs";

        public Datei(string name, string text) 
        {
            this.name = name;
            this.text = text;

        }

        public void Save(string path)
        {
           var dateiName = Path.Combine(name,DateiTyp);
           var fullPath = Path.Combine(path,dateiName);

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }

            File.WriteAllText(fullPath,text);
        }
        

    }
}
