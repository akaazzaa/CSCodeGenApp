using CSCodeGen.Model.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Model.Interfaces.View
{
    public interface ITemplateEditorView : IView
    {
        public event EventHandler<Template> OnSaveChanges;
        public event EventHandler<Template> OnResetChanges;
        public event EventHandler<string> OnCodeChanged;
        public event EventHandler UpdatePlatzhalter;
        public event EventHandler OnKeywordDeleted;

        public void SetDock();
        
    }
}
