using CSCodeGen.DataAccess.Model.Config;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSCodeGen.DataAccess.Model
{
    public class Keyword : INotifyPropertyChanged
    {

        private static int _nextId = 1;
        private string _code;
        private string _dataType;
        private string _name;
        private bool _prefixWithComment;

        public int Id { get; set; }
        public string Name
        {
            get => _name;
            set
            {
                _name = value.Trim();
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
            get => _dataType.Trim();
            set
            {
                _dataType = value.Trim();
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
            Id = _nextId++;
            _code = string.Empty;
            _dataType = string.Empty;
            _name = string.Empty;
            _prefixWithComment = true;
        }


        public Keyword(string key)
        {
            Id = _nextId++;
            Name = key;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public override bool Equals(object obj)
        {
            if (obj is Keyword other)
            {
                return this.Id == other.Id; // Alternativ: this.Name.Equals(other.Name, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode(); // Alternativ: return Name?.GetHashCode() ?? 0;
        }
    }
}
