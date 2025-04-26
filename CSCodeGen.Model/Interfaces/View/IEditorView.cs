using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Model.Interfaces.View
{
    public interface IEditorView
    {
        public event EventHandler<string> CodeChanged;
        public event EventHandler GetDefaultKeys;
        public event EventHandler UpdatePlatzhalter;
        void Initialize<T>(T obj);
    }
}
