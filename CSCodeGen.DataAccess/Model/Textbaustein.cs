using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.Remoting.Channels;

namespace CSCodeGen.DataAccess.Model
{
    public class Textbaustein : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonIgnore]
        public string name;
        [JsonIgnore]
        public string defaultValue;
        [JsonIgnore]
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

        public Textbaustein()
        {
            
        }
        public Textbaustein(string name, string defaultValue = "", string switchpoint = "")
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
