using System.Collections.Generic;

namespace CSCodeGen.DataAccess.Model
{
    public class Template
    {
        public string Name { get; set; }
        public string Source { get; set; }
        public List<Textbaustein> Keywords { get; set; } = new List<Textbaustein>();

        public Template(DataType type)
        {



            Source = "<#{namspace}#>";


            //switch (type)
            //{
            //    case DataType.Klasse:

            //        Content = 
            //        break;
            //}
        }
    }
}
