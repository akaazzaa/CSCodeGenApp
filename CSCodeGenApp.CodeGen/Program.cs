

using CSCodeGen.DataAccess.Model.Storage;
using CSCodeGen.Library.Controller;
using CSCodeGen.Model.Interfaces;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;
using System.Configuration;

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
            string templateFolder= string.Empty;

            if (ConfigurationManager.AppSettings["FolderName"] != null)
            {
                templateFolder = ConfigurationManager.AppSettings["FolderName"];
            }

            string templatePath = Path.Combine(Directory.GetCurrentDirectory(), templateFolder );

            if (!Directory.Exists(templatePath))
            {
                Directory.CreateDirectory(templatePath);
            }

            IRepository<Template> templateRepo = new TemplateRepository(templatePath);
            IRepository<Result> resultRepo = new ResultRepository();
            IClassView view = new frmCodeGen();

            ClassController classController = new ClassController(resultRepo,templateRepo,view);

            ApplicationConfiguration.Initialize();
            Application.Run((frmCodeGen)view);
        }
    }
}