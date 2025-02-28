using System;
using System.ComponentModel;

namespace CSCodeGen.DataAccess.Model.Main
{
    public class Observable
    {
        private bool _isChanged = false;

        [Browsable(false)]
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

        public event Action Changed;

        protected void MarkAsChanged()
        {
            IsChanged = true;
        }

        protected virtual void OnChanged()
        {
            Changed?.Invoke();
        }
    }
}
