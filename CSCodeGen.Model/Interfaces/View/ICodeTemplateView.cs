using CSCodeGen.Model.Args;
using CSCodeGen.Model.Main;
using System.ComponentModel;

namespace CSCodeGen.Model.Interfaces.View
{
     public interface ICodeTemplateView : IView 
    {
        event EventHandler LoadTemplates;
        event EventHandler SaveAll;
        event EventHandler<TemplateEventArgs> SaveTemplate;
        event EventHandler<TemplateEventArgs> NewTemplate;
        event EventHandler<TemplateEventArgs> AddKeyword;
        event EventHandler<TemplateEventArgs> RemoveKeyword;
        event EventHandler<TemplateEventArgs> DeleteKeyword;
  
        void ShowTemplates(BindingList<Template> templates);
        void ShowMessage(string message);
        bool ShowMessagBox(string message, string caption);
        string UseFileDialog();
    }
}
