

using CSCodeGen.Library;

namespace CSCodeGen.Ui
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainController.Register<TemplateController>(new TemplateController());
            MainController.Register<PlaceholderController>(new PlaceholderController());


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}