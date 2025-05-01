



using CSCodeGen.DataAccess.Helper;
using CSCodeGen.DataAccess.Model.Storage;
using CSCodeGen.Library.Controller;
using CSCodeGen.Model.Args;
using CSCodeGen.Model.Interfaces;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;
using CSCodeGen.Model.Settings;
using CSCodeGen.UI.Ui;
using NLog;
using System;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace CSCodeGen.UI
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigData.SetupLogConfig();



            string templateFolder = string.Empty;

            if (ConfigurationManager.AppSettings["FolderName"] != null)
            {
                templateFolder = ConfigurationManager.AppSettings["FolderName"];
            }

            string templatePath = Path.Combine(Directory.GetCurrentDirectory(), templateFolder);
            Globals.FolderPath = templatePath;
            
            IRepository<Template> storage = new TemplateRepository(templatePath);
            ICodeTemplateView view = new TemplateDesignerForm();
            
            TemplateController templateController = new TemplateController(storage,view);

            Application.Run((Form)view);
        }
    }
}
