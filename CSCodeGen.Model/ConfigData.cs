using CSCodeGen.Model.Main;

namespace CSCodeGen.Model
{
    public static class ConfigData
    {
        private static DefaultKeyword keywords = null;
        public static string CommentPrefix => "//";
        public static string Prefix => "<#";
        public static string Postfix => "#>";
        public static DefaultKeyword Keywords
        {
            get
            {
                if (keywords == null)
                {
                    keywords = new DefaultKeyword();
                }

                return keywords;
            }
        }

        public static IEnumerable<Keyword> GetDefaultKeywords()
        {
            return new List<Keyword>
        {
            new Keyword { Id = 100, Name = Keywords.Classname, PrefixWithComment = false },
            new Keyword { Id = 200, Name = Keywords.Propertie, PrefixWithComment = false },
            new Keyword { Id = 300, Name = Keywords.Namespace, PrefixWithComment = false },
            new Keyword { Id = 400, Name = Keywords.Variable, PrefixWithComment = false }
        };
        }



    }
}
