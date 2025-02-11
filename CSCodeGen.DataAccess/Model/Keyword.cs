using CSCodeGen.DataAccess.Model.Config;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSCodeGen.DataAccess.Model
{
    public class Keyword : INotifyPropertyChanged
    {
        private string _code;
        private string _dataType;
        private string _name;
        private bool _prefixWithComment;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(); // automatisch "Name"
            }
        }

        public string Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(); // automatisch "Code"
            }
        }

        public string DataType
        {
            get => _dataType;
            set
            {
                _dataType = value;
                OnPropertyChanged(); // automatisch "DataType"
            }
        }

        public bool PrefixWithComment
        {
            get => _prefixWithComment;
            set
            {
                _prefixWithComment = value;
                OnPropertyChanged(); // automatisch "PrefixWithComment"
            }
        }

        public string DisplayText => $"{Configuration.Prefix}{Name}{Configuration.Postfix}";

        public Keyword()
        {
            _code = string.Empty;
            _dataType = string.Empty;
            _name = string.Empty;
            _prefixWithComment = true;
        }

        // Optional: ein Konstruktor, der z.B. initial den Namen setzt.
        public Keyword(string key)
        {
            Name = key;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
