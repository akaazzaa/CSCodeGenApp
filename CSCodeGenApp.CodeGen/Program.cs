using CSCodeGen.Library.GlobalEvents;

namespace CSCodeGenApp.CodeGen
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            CoreGlobals.Instance.Init();




            ApplicationConfiguration.Initialize();
            Application.Run(new frmCodeGen());
        }
    }
}