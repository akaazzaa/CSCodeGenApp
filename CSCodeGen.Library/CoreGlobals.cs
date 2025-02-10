using CSCodeGen.DataAccess.Model;
using System;
using System.IO;

namespace CSCodeGen.Library
{
    public class CoreGlobals
    {
        private static CoreGlobals _instance;
        private static readonly object _lock = new object();

        public TemplateController templateController;
        public TextbausteinController textbausteinController;


        private JsonStorage<Template> templateStorage;
        private JsonStorage<Textbaustein> textbausteinStorage;

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
            templateStorage = new JsonStorage<Template>(MainDirectoryPath + "/Templates/Template.json");
            textbausteinStorage = new JsonStorage<Textbaustein>(MainDirectoryPath + "/Templates/Textbaustein.json");
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
            templateController = new TemplateController(templateStorage);
            textbausteinController = new TextbausteinController(textbausteinStorage);
        }

        public static void LogMessage(string message)
        {

            Console.WriteLine($"{message}");
        }

        public void Save()
        {
            templateController.Save();
            textbausteinController.Save();
        }
    }
}
