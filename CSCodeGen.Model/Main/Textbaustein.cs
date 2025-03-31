using CSCodeGen.Model.Settings;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSCodeGen.Model.Main
{
    public class Textbaustein : INotifyPropertyChanged
    {
        #region Variabeln
        private Guid _guid;
        private string _code;
        private DataType _type;
        private string _name;
        private bool _prefixWithComment;
        #endregion

        #region Properties
        public int Id 
        {
            get
            {
                return _guid.GetHashCode();
            } 
           
        }
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
        public DataType Type
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

                stringBuilder.Append($"{ConfigData.Prefix}{Name}{ConfigData.Postfix}");

                return stringBuilder.ToString();
            }
        }
        #endregion

        #region Konstruktoren
        public Textbaustein()
        {
            _guid = Guid.NewGuid();
            _code = string.Empty;
            _name = string.Empty;
            _prefixWithComment = true;
        }
        public Textbaustein(string key)
        {
            _guid = Guid.NewGuid();
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
