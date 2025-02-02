using System.ComponentModel;
using System.Runtime.Remoting.Channels;

namespace CSCodeGen.DataAccess.Model
{
    public class Placeholder : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string name;
        public string defaultValue;
        public string switchPoint;




        public string Name 
        {

            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string DefaultValue
        {
            get
            {
                return defaultValue;
            }

            set
            {
                defaultValue = value;
                OnPropertyChanged("DefaultValue");
            }
        }

        public string Switchpoint
        {
            get
            {
                return switchPoint;
            }

            set
            {
                switchPoint = value;
                OnPropertyChanged("Switchpoint");
            }
        }

        public Placeholder()
        {
            
        }
        public Placeholder(string name, string defaultValue = "", string switchpoint = "")
        {
            Name = name;
            DefaultValue = defaultValue;
            Switchpoint = switchpoint;
        }
        public override string ToString()
        {
            return $"{DefaultValue}";
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }

    }
}
