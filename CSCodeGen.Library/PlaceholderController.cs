using CSCodeGen.DataAccess;
using CSCodeGen.DataAccess.Model;
using CSCodeGen.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;

namespace CSCodeGen.Library
{
    public class PlaceholderController 
    {
        private PlaceholderRepository repository;
        public event EventHandler PlaceholderChanged;

        public PlaceholderController(PlaceholderRepository repossitory)
        {
            this.repository = repossitory;
        }

        public BindingList<Textbaustein> GetTextbausteinList()
        {
            return repository.GetAll();
        }
        public void Add(Textbaustein placeholder)
        {
            repository.Add(placeholder);
        }

        public void Remove(Textbaustein placeholder)
        {
            repository.Remove(placeholder);
        }

        public void Save() => repository.Save();

        

        public static string SearchandRepalce(string text,Textbaustein placeholder)
        {
            string tmp = string.Empty;
            var temp = text.Split();

            if (placeholder == null)
            {
                return string.Empty;
            }

            if (string.IsNullOrEmpty(placeholder.Switchpoint))
            {
                // Event das Fehler ausgibt 
                CoreGlobals.LogMessage($"{placeholder.Switchpoint}");
                return null;
            } 

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == placeholder.Switchpoint)
                {
                    temp[i] = placeholder.DefaultValue;
                }


                tmp += temp[i];
                
            }

            return tmp;
        }

        public void OnPlaceholderChanged()
        {
            PlaceholderChanged?.Invoke(this,new EventArgs());
        }


        /// Das Template wird beim erstellen mit Schlüsselwörtern versehen die, die Positione der Texbausteine sind. 
        /// Texbausteine haben ein ein Schlüssel wort. wenn ich ein Texbaustein in den Text einfüge wird es and der stelle des jeweiligen schlüsselwortes eingefügt. 
        /// 
        /// 
        /// 
        
        public string ReplaceKeywords(string text, Textbaustein textbaustein)
        {
            Dictionary<string, string> keywordMappings = new Dictionary<string, string>
        {
            { "<{append.variable}>", $"private string {textbaustein.Name};\r" },
            { "<{append.namespace}>", "textbaustein" },
        };

            foreach (var keyword in keywordMappings)
            {
                text = text.Replace(keyword.Key, keyword.Value);
            }

            return text;

        }
    }

}

