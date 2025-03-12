using CSCodeGen.Model.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Model.Args
{
    public class GeneratorEventArgs
    {
        public Template Template { get; set; } = null;
        public Result Result { get; set; } = null;
        public UserValue UserValue { get; set; } = null;
    }
}
