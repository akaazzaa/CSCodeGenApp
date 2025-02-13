using System;

namespace CSCodeGen.DataAccess.Model
{
    public class Observable
    {
        private bool _isChanged = false;

        public bool IsChanged
        {
            get { return _isChanged; }
            set
            {
                if (_isChanged != value)
                {
                    _isChanged = value;
                    OnChanged();
                }
            }
        }

        // Ereignis, das ausgelöst wird, wenn sich etwas geändert hat
        public event Action Changed;

        // Methode, die eine Änderung anzeigt (kann für beliebige Eigenschaften verwendet werden)
        protected void MarkAsChanged()
        {
            IsChanged = true;
        }

        // Wird aufgerufen, wenn sich etwas ändert
        protected virtual void OnChanged()
        {
            Changed?.Invoke();
        }


    }
}
