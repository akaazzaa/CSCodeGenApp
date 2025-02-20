using CSCodeGen.DataAccess.Model.Config;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

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
            _code = string.Empty;
            _dataType = string.Empty;
            _name = string.Empty;
            _prefixWithComment = true;
        }

       
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
