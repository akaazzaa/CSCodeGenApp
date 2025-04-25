using CSCodeGen.Model.Args;
using CSCodeGen.Model.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Model.Interfaces.View
{
    public interface IClassView : IView
    {
        event EventHandler LoadTemplates;
        event EventHandler<GeneratorEventArgs> GenerateCode;

        void ShowText(string text);
        void Show(BindingList<Template> templates);
        void ShowMessage(string message);
    }
}
