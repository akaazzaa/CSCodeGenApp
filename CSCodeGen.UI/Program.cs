



using CSCodeGen.DataAccess.Model.Storage;
using CSCodeGen.Library.Controller;
using CSCodeGen.Model.Args;
using CSCodeGen.Model.Interfaces;
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


            string templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Templates");

            if (!Directory.Exists(templatePath))
            {
                Directory.CreateDirectory(templatePath);
            }

            ITemplateRepository storage = new XmlRepository(templatePath);
            ICodeTemplateView view = new TemplateDesignerForm();


            TemplateController templateController = new TemplateController(storage,view);

            Application.Run((Form)view);
        }
    }
}
