using CSCodeGen.DataAccess.Model.Config;
using CSCodeGen.DataAccess.Model.Storage;
using CSCodeGen.Library.Controller;
using System;
using System.IO;



namespace CSCodeGen.Library.GlobalEvents
{
    public class CoreGlobals
    {
        private static CoreGlobals _instance;
        private static readonly object _lock = new object();

        public TemplateController templateController;
        public ClassController classController;
        public XmlTemplateStorage templateStroage;
        public Settings settings;


        public string MainDirectoryPath
        {
            get
            {
                return Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName;
            }

        }

        public string SaveCSPath
        {
            get
            {
                return Path.Combine(MainDirectoryPath, "Daten");

            }
        }

        // Private Konstruktor
        private CoreGlobals()
        {
            //
            //MainDirectoryPath + "/Templates/Template.json"
            //MainDirectoryPath + "/Templates/Textbaustein.json "C:\\Users\\dgami\\source\\repos\\akaazzaa\\CSCodeGenApp\\CSCodeGen.DataAccess\\Templates\\Textbaustein.xml"
            //Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName

        }

        // Singleton-Instanzzugriff
        public static CoreGlobals Instance
        {
            get
            {

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

            templateStroage = new XmlTemplateStorage(Path.Combine(MainDirectoryPath, "Templates"));
            templateController = new TemplateController(templateStroage);
            classController = new ClassController();
            settings = new Settings();
        }

    }
}
