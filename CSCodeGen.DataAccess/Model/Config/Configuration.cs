namespace CSCodeGen.DataAccess.Model.Config
{
    public class Configuration
    {
        private static KeywordConfiguration _Keywords = null;

        public static KeywordConfiguration Keywords
        {
            get
            {
                if (_Keywords == null)
                {
                    _Keywords = new KeywordConfiguration();
                }

                return _Keywords;
            }
        }

        public static string Prefix => "<#";
        public static string Postfix => "#>";

    }
}
