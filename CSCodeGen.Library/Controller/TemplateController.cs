using CSCodeGen.DataAccess.Interface;
using CSCodeGen.DataAccess.Model.Main;
using System.ComponentModel;

namespace CSCodeGen.Library.Controller
{
    public class TemplateController
    {
        
        private readonly ITemplateStorage _templateStorage;

        public TemplateController(ITemplateStorage templateStorage)
        {
            _templateStorage = templateStorage;
        }

        public BindingList<CodeTemplate> GetList()
        {
            return _templateStorage.GetTemplates();
        }

        #region Laden und Speichern 
        public void Save()
        {
            _templateStorage.SaveAll();
        }
       

        #endregion
    }
}
