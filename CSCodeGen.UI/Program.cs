using CSCodeGen.Library;
using System;
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
            CoreGlobals.Instance.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TemplateDesignerForm());
        }
    }
}
