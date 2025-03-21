﻿using CSCodeGen.Model.Main;
using CSCodeGen.Model.Interfaces;
using System.IO;
using System.ComponentModel;

namespace CSCodeGen.DataAccess.Model.Storage
{
    public class ResultRepository : IRepository<Result>
    {
        public ResultRepository() 
        {
            
        }

        public BindingList<Result> GetData()
        {
            throw new System.NotImplementedException();
        }

        public void Add(Result obj)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Result result)
        {
            File.WriteAllText("filePath", result.Content);
        }

        public void SaveAll()
        {
            throw new System.NotImplementedException();
        }

        public void LoadAll()
        {
           
        }

        public Result Load(string path)
        {
            var result = new Result();

            if (File.Exists(path))
            {
                result.Name = Path.GetFileNameWithoutExtension(path);
                result.Content = File.ReadAllText(path);

            } 

            return result;
        }
    }
}
