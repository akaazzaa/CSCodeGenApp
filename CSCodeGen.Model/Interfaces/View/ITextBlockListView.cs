using CSCodeGen.Model.Main;

namespace CSCodeGen.Model.Interfaces.View
{
   public interface ITextBlockListView : IView
    {
        void ShowKeywords(IEnumerable<Textbaustein> keywords);
    }
  
}