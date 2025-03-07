using CSCodeGen.DataAccess.Interface;
using CSCodeGen.DataAccess.Model.Main;
using CSCodeGen.DataAccess.Model.Storage;
using CSCodeGen.Library.Controller;
using CSCodeGen.Library.GlobalEvents;
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
            string folderPath = Path.Combine(CoreGlobals.Instance.MainDirectoryPath, "Templates");

            BindingList<CodeTemplate> templates = new BindingList<CodeTemplate>();

            ITemplateStorage templateStroage = new XmlTemplateStorage(folderPath, templates);

            TemplateController templateController = new TemplateController(templateStroage);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TemplateDesignerForm(templateController));
        }
    }
}
