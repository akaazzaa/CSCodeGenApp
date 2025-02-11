using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSCodeGen.DataAccess.Model
{
    public class Template : INotifyPropertyChanged
    {


        private string _Name;
        private string _Source;
        private string _Description;


        [Category("Template")]
        [Description("Name des Templates")]
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                NotifyPropertyChanged();


            }
        }


        [Category("Template")]
        [Description("Beschreibung des Templates")]
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {


                _Description = value;
                NotifyPropertyChanged();

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
            get
            {
                return _Source;
            }
            set
            {

                _Source = value;
                NotifyPropertyChanged("Source");

            }
        }

        [Category("Template")]
        [Description("Liste der Keywords")]
        public BindingList<Keyword> Keywords { get; set; }


        public Template()
        {
            Name = string.Empty;
            Description = string.Empty;
            CreationDate = DateTime.Now;
            Source = string.Empty;
            Keywords = new BindingList<Keyword>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
