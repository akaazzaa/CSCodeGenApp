using System;
using System.ComponentModel;

namespace CSCodeGen.Model.Main
{
    public abstract class Observable
    {

        [Browsable(false)]
        public bool IsChanged { get;  set; }

            public void MarkAsChanged()
            {
                if (!IsChanged)
                {
                    IsChanged = true;
                }
            }

            public void AcceptChanges()
            {
                IsChanged = false;
            }

         
        
    }
}

