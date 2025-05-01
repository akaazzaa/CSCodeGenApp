using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Model.Main
{
    public class Globals
    {
        private static string? _FolderPath;
        public static string? FolderPath
        {
            get
            {

                return _FolderPath;
            }

            set
            {
                _FolderPath = value;
            }
        }

    }
}
