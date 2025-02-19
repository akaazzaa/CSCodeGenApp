using CSCodeGen.DataAccess.Model.Config;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSCodeGen.DataAccess.Model
{
    public class Keyword : INotifyPropertyChanged
    {
        private static int _nextID = 1;

        private string _code;
        private string _dataType;
        private string _name;
        private bool _prefixWithComment;

        public int ID { get; }


        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged();
            }
        }

        public string DataType
        {
            get => _dataType;
            set
            {
                _dataType = value;
                OnPropertyChanged();
            }
        }

        public bool PrefixWithComment
        {
            get => _prefixWithComment;
            set
            {
                _prefixWithComment = value;
                OnPropertyChanged();
            }
        }

        public string DisplayText
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                if (_prefixWithComment)
                {
                    stringBuilder.Append("//");
                }

                stringBuilder.Append($"{Configuration.Prefix}{Name}{Configuration.Postfix}");

                return stringBuilder.ToString();
            }
        }


        public Keyword()
        {
            ID = _nextID++;
            _code = string.Empty;
            _dataType = string.Empty;
            _name = string.Empty;
            _prefixWithComment = true;
        }

        // Optional: ein Konstruktor, der z.B. initial den Namen setzt.
        public Keyword(string key)
        {
            ID = _nextID++;
            Name = key;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
