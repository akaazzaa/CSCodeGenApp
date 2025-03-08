using CSCodeGen.Model.Main;

namespace CSCodeGen.Model.Model
{
    public static class Configuration
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
            new Keyword { Id = 100, Name = Configuration.Keywords.Classname, PrefixWithComment = false },
            new Keyword { Id = 200, Name = Configuration.Keywords.Propertie, PrefixWithComment = false },
            new Keyword { Id = 300, Name = Configuration.Keywords.Namespace, PrefixWithComment = false },
            new Keyword { Id = 400, Name = Configuration.Keywords.Variable, PrefixWithComment = false }
        };
        }



    }
}
