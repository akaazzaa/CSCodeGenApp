using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Model.Main
{
    public class Result
    {
        public string Name { get; set; }

        public string Content { get; set; }

        public List<UserValue> userValues { get; set; }

        public Result()
        {
            Name = string.Empty;
            Content = string.Empty;
            userValues = new List<UserValue>();
        }
    }
}
