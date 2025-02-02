using CSCodeGen.DataAccess;
using CSCodeGen.DataAccess.Model;
using CSCodeGen.DataAccess.Repository;
using CSCodeGen.Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Console.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var json = new JsonStorage<Template>(Path.Combine(CoreGlobals.Instance.MainDirectoryPath, "Templates", "Template.json"));
            var repo = new TemplateRepossitory(json);

            TemplateController templateController = new TemplateController(repo);

            


        }
    }
}
