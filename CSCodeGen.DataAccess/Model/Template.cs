using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSCodeGen.DataAccess.Model
{
    public class Template : Ueberwacht, INotifyPropertyChanged
    {

        private string _Name;
        private string _Source;
        private string _Description;

        // Properties
        [Category("Template")]
        [Description("Name des Templates")]
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

                    _Name = value;
                    NotifyPropertyChanged();

                }
            }
        }

        [Category("Template")]
        [Description("Beschreibung des Templates")]
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
        public DateTime CreationDate { get; set; }

        [Category("Information")]
        [Description("Quellcode des Templates")]
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
        public BindingList<Keyword> Keywords { get; set; }

        public Template()
        {
            CreationDate = DateTime.Now;
            Keywords = new BindingList<Keyword>();
            IsChanged = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
