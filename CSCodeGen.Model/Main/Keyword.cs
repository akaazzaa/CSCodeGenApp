using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSCodeGen.Model.Main
{
    public class Keyword : INotifyPropertyChanged
    {
        #region Variabeln
        private static int _nextId = 1;
        private string _code;
        private KeywordType _type;
        private string _name;
        private bool _prefixWithComment;
        #endregion

        #region Properties
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
        public KeywordType Type
        {
            get => _type;
            set
            {
                _type = value;
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
        #endregion

        #region Konstruktoren
        public Keyword()
        {
            Id = _nextId++;
            _code = string.Empty;
            _name = string.Empty;
            _prefixWithComment = true;
        }
        public Keyword(string key)
        {
            Id = _nextId++;
            Name = key;

        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
