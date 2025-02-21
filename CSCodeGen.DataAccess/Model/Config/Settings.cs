using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.DataAccess.Model.Config
{
    public class Settings
    {
        public bool isTest { get; set; }

        public Settings() 
        {
            isTest = false;
        }
    }
}

