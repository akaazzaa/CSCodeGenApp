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

        public BindingList<Placeholder> GetPlaceholderList()
        {
            return repository.GetAll();
        }
        public void Add(Placeholder placeholder)
        {
            repository.Add(placeholder);
        }

        public void Remove(Placeholder placeholder)
        {
            repository.Remove(placeholder);
        }

        public virtual void Save() => repository.Save();

        public static string SearchandRepalce(string text,Placeholder placeholder)
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
    }

}

