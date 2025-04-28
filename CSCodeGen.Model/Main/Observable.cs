using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CSCodeGen.Model.Main
{
    public abstract class Observable
    {

        //[Browsable(false)]
        [XmlIgnore]
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

