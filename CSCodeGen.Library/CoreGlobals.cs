using CSCodeGen.DataAccess.Model;
using CSCodeGen.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Library
{
    public class CoreGlobals
    {
        private static CoreGlobals _instance;
        private static readonly object _lock = new object();

        public TemplateController templateController;
        public PlaceholderController placeholderController;


        private JsonStorage<Template> templateStorage;
        private JsonStorage<Placeholder> placeholderStorage;

        public string MainDirectoryPath 
        { 
            get 
            { 
                return Directory.GetCurrentDirectory(); 
            } 
            
        } 
        // Private Konstruktor
        private CoreGlobals() 
        {
            templateStorage = new JsonStorage<Template>(MainDirectoryPath + "/Templates/Template.json" );
            placeholderStorage = new JsonStorage<Placeholder>(MainDirectoryPath + "/Templates/Textbaustein.json" );
        }

        // Singleton-Instanzzugriff
        public static CoreGlobals Instance
        {
            get
            {
                // Thread-sicherstellen Instanz erstellen
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CoreGlobals();
                    }
                    return _instance;
                }
            }
        }
      
        // Hilfsmethode
        public void Init()
        {
            templateController = new TemplateController(new TemplateRepossitory(templateStorage));
            placeholderController = new PlaceholderController(new PlaceholderRepository(placeholderStorage));
        }

        public static void LogMessage( string message)
        {
            
            Console.WriteLine($"{message}");
        }

        public void Save()
        {
            templateController.Save();
            placeholderController.Save();
        }
    }
}
