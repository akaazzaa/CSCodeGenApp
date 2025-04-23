using System;
using System.ComponentModel;

namespace CSCodeGen.Model.Main
{
    public abstract class Observable
    {

        [Browsable(false)]
        public bool IsChanged { get;  set; }
        public abstract object _copy { get; set; }

        protected abstract void CreateCopy();
        protected abstract void RevertChanges();

            public void MarkAsChanged()
            {
                if (!IsChanged)
                {
                    IsChanged = true;
                    // Erstelle eine Kopie des aktuellen Zustands
                    CreateCopy();
                }
            }

            public void AcceptChanges()
            {
                IsChanged = false;
            }

            // Diese Methode stellt den ursprünglichen Zustand wieder her
            public void Revert()
            {
                RevertChanges();
                IsChanged = false;
            }
        
    }
}

