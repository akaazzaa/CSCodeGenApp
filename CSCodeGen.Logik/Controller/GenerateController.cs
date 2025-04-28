

using CSCodeGen.DataAccess.Model.Storage;
using CSCodeGen.Model;
using CSCodeGen.Model.Args;
using CSCodeGen.Model.Interfaces;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;
using CSCodeGen.Model.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSCodeGen.Library.Controller
{
    public class GenerateController
    {
        
        IRepository<Result> _resultRepository;
        IRepository<Template> _templateRepository;
        IClassView _view;

        

        public GenerateController(IRepository<Result> resultRepo, IRepository<Template> templateRepo,IClassView classView)
        {
            _templateRepository = templateRepo;

            _view = classView;
            _view.LoadTemplates += OnLoadTemplates;
            _view.GenerateCode += OnGenerateCode;
        }

        private void OnGenerateCode(object sender, GeneratorEventArgs args)
        {
            string tmp = ReplaceUserValuesInTemplate(args);
            _view.ShowText(tmp);
        }

        private void OnLoadTemplates(object sender, EventArgs e)
        {
            _templateRepository.LoadAll();
            _view.Show(_templateRepository.GetData());
        }

        private string ReplaceUserValuesInTemplate(GeneratorEventArgs args)
        {
            if (args.Template == null || args.Result.userValues == null || string.IsNullOrEmpty(args.Template.Content))
                throw new ArgumentNullException("Template, UserValues oder Template.Content darf nicht null sein.");

            string updatedContent = args.Template.Content;

            foreach (var userValue in args.Result.userValues)
            {
                // Suche nach einem passenden Textbaustein basierend auf dem Datentyp
                var matchingTextbaustein = args.Template.Textbausteine.FirstOrDefault(tb => tb.Type == userValue.Type);

                if (matchingTextbaustein != null)
                {
                    // Ersetze den Code des Textbausteins im Template.Content
                    updatedContent = updatedContent.Replace(matchingTextbaustein.Code, userValue.Value);
                }
            }

            return updatedContent;
        }
    

    }

}

