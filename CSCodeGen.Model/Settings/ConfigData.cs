﻿using CSCodeGen.Model.Main;

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
            new Textbaustein {  Name = DefaultBaustein.Classname, PrefixWithComment = false },
            new Textbaustein {  Name = DefaultBaustein.Propertie, PrefixWithComment = false },
            new Textbaustein {  Name = DefaultBaustein.Namespace, PrefixWithComment = false },
            new Textbaustein {  Name = DefaultBaustein.Variable, PrefixWithComment = false }
        };
        }

    }
}
