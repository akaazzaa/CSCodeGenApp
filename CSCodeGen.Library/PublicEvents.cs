using CSCodeGen.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.Library
{
    public static class PublicEvents
    {
        public static event Action<Keyword> KeywordDeleted;

        public static void OnKeywordDeleted(Keyword keyword)
        {
            KeywordDeleted?.Invoke(keyword);
        }
    }
}
