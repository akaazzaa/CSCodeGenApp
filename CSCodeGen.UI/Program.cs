


using CSCodeGen.Contracts.Interfaces;
using CSCodeGen.DataAccess.Model.Storage;
using CSCodeGen.Library.Controller;
using CSCodeGen.Model.Main;
using System;
using System.ComponentModel;
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

            if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Templates")))
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Templates"));
            }
            string templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Templates");

            ITemplateStorage<CodeTemplate> storage = new XmlStorage(templatePath);
            // Beispielhafte Implementierung
            ICodeTemplateView<CodeTemplate> view = new TemplateDesignerForm();
            TemplateController templateController = new TemplateController(storage,view);

            Application.Run((Form)view);
        }
    }
}
