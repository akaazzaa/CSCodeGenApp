using CSCodeGen.Model.Main;

namespace CSCodeGen.Model.Settings
{
    public static class ConfigData
    {
        private static DefaultText keywords = null;
        public static string CommentPrefix => "//";
        public static string Prefix => "<#";
        public static string Postfix => "#>";
        public static DefaultText DefaultBaustein
        {
            get
            {
                if (keywords == null)
                {
                    keywords = new DefaultText();
                }

                return keywords;
            }
        }

        public static IEnumerable<Textbaustein> GetDefaults()
        {
            return new List<Textbaustein>
        {
            new Textbaustein { Id = 100, Name = DefaultBaustein.Classname, PrefixWithComment = false },
            new Textbaustein { Id = 200, Name = DefaultBaustein.Propertie, PrefixWithComment = false },
            new Textbaustein { Id = 300, Name = DefaultBaustein.Namespace, PrefixWithComment = false },
            new Textbaustein { Id = 400, Name = DefaultBaustein.Variable, PrefixWithComment = false }
        };
        }

    }
}
