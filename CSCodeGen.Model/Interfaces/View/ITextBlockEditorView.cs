using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;

namespace CSCodeGen.Model.Interfaces.View
{
    public interface ITextBlockEditorView : IView
    {
        event EventHandler<Textbaustein> TextBlockChanged;
        void OnTextBlockChange(Textbaustein keyword);
    }
}