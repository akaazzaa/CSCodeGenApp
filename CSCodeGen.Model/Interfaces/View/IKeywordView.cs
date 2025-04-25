using CSCodeGen.Model.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Model.Interfaces.View
{
    public interface IKeywordView
    {
        event EventHandler LoadKeywords;
        event EventHandler SaveAll;
        event EventHandler SaveKeyword;
        event EventHandler NewKeyword;
        event EventHandler RemoveKeyword;
        void ShowKeywords(IEnumerable<Textbaustein> keywords);
        void SetKeyword(Textbaustein keyword);
        void SetKeywordError(string error);
    }
}
