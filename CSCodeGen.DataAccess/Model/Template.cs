using System;
using System.ComponentModel;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace CSCodeGen.DataAccess.Model
{
    [DataContract]
    public class Template : Observable, INotifyPropertyChanged
    {
        private static int nextid = 1;
        #region Variabeln
        private string _Name;
        private string _Source;
        private string _Description;
        private string _Filename;
        #endregion

        #region Properties
        // Readonly 
        [DataMember]
        public string FileName
        {
            get
            {
                return _Name + ".xml";
            }
        }
        // Properties
        [DataMember] public string OldFileName { get; set; }
       
        [Category("Template")]
        [Description("ID")]
        [DataMember] public int ID { get; }

        [Category("Template")]
        [Description("Name des Templates")]
        [DataMember]
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name != value)
                {
                    if (_Name != null)
                    {
                        MarkAsChanged();
                    }

                    OldFileName = _Name;
                    _Name = value;
                    NotifyPropertyChanged();

                }
            }
        }

        [Category("Template")]
        [Description("Beschreibung des Templates")]
        [DataMember]
        public string Description
        {
            get { return _Description; }
            set
            {
                if (_Description != value)
                {
                    if (_Description != null)
                    {
                        MarkAsChanged();
                    }

                    _Description = value;
                    NotifyPropertyChanged();

                }
            }
        }

        [ReadOnly(true)]
        [Category("Information")]
        [Description("Anlagedatum des Templates")]
        [DataMember] public DateTime CreationDate { get; set; }

        [Category("Information")]
        [Description("Quellcode des Templates")]
        [DataMember]
        public string Source
        {
            get { return _Source; }
            set
            {
                if (_Source != value)
                {
                    if (_Source != null)
                    {
                        MarkAsChanged();
                    }

                    _Source = value;
                    NotifyPropertyChanged();

                }
            }
        }

        [Category("Template")]
        [Description("Liste der Keywords")]
        [DataMember] public BindingList<Keyword> Keywords { get; set; }
        #endregion
        public Template()
        {
            ID = nextid++;
            CreationDate = DateTime.Now;
            Keywords = new BindingList<Keyword>();
            IsChanged = true;
        }

        public Template(string name )
        {
            Name = name;
            ID = nextid++;
            CreationDate = DateTime.Now;
            Keywords = new BindingList<Keyword>();
            IsChanged = true;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ChangeFileName()
        {

        }

    }
}
