using System.ComponentModel;

namespace CSCodeGen.Contracts.Interfaces
{
     public interface ICodeTemplateView<T> where T : class
    {
        
        void ShowTemplates(BindingList<T> templates);
        void ShowMessage(string message);
        event EventHandler LoadTemplates;
        event EventHandler<T> SaveTemplate;
        event EventHandler<T> NewTemplate;
        
    }
}
