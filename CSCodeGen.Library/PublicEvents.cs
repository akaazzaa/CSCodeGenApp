using CSCodeGen.DataAccess.Model;
using System;

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
