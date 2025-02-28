using System.ComponentModel;

namespace CSCodeGen.DataAccess.Model
{
    public class Klasse
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    name = value;
                }
            }
        }

        private string code;
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                if (value != code)
                {
                    code = value;
                }
            }
        }

        public string Namespace { get; set; }
        public BindingList<Propertie> Properties { get; set; } = new BindingList<Propertie>();


    }
}
