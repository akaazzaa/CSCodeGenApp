using CSCodeGen.DataAccess.Model.Main;
using System;

namespace CSCodeGen.Library.GlobalEvents
{
    public static class PublicEvents
    {
        public static event Action<Keyword> KeywordDeleted;
        public static event Action SaveChanges;
        public static void OnKeywordDeleted(Keyword keyword)
        {
            KeywordDeleted?.Invoke(keyword);
        }

        public static void OnSaveChanges()
        {
            SaveChanges?.Invoke();
        }


    }
}
