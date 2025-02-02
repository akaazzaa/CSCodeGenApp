using System.ComponentModel;

namespace CSCodeGen.DataAccess.Model
{
    public class Template : INotifyPropertyChanged
    {
        private string name;
        private string content;

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
        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
                OnPropertyChanged("Content");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
