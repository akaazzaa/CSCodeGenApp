using CSCodeGen.Model.Interfaces;
using CSCodeGen.Model.Settings;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSCodeGen.Model.Main
{
    public class Textbaustein :  Observable, INotifyPropertyChanged 
    {
        #region Variabeln
        private Guid _guid;
        private string _code;
        private DataType _type;
        private string _name;
        private bool _prefixWithComment;
        #endregion

        #region Properties
        public Guid ID 
        {
            get
            {
                return _guid;
            } 

            set
            {
                if (_guid != value)
                {
                    _guid = value;
                }
            }
           
        }
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    if (_name != null)
                    {
                        MarkAsChanged();
                    }

                    
                    _name = value.Trim();
                    OnPropertyChanged();
                }
            }
        }
        public string Code
        {
            get => _code;
            set
            {
                if(_code != value)
                {
                    if (_code != null)
                    {
                        MarkAsChanged();
                    }
                    _code = value;
                    OnPropertyChanged();
                }
               
            }
        }
        public DataType Type
        {
            get => _type;
            set
            {
                if (_type != value)
                {
                    MarkAsChanged();
                    _type = value;
                    OnPropertyChanged();
                }              
            }
        }
      
        public bool PrefixWithComment
        {
            get => _prefixWithComment;
            set
            { 
                if (_prefixWithComment != value)
                {
                    
                    MarkAsChanged();
                    _prefixWithComment = value;
                    OnPropertyChanged();
                }
                
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
