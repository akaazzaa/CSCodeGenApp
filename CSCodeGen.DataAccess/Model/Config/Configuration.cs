namespace CSCodeGen.DataAccess.Model.Config
{
    public class Configuration
    {
        private static DefaultKeyword keywords = null;
        private static TextKeyword testKeywords = null;

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

        public static TextKeyword TestKeywords
        {
            get
            {
                if (testKeywords == null)
                {
                    testKeywords = new TextKeyword();
                }

                return testKeywords;
            }
        }

        public static string CommentPrefix => "//";
        public static string Prefix => "<#";
        public static string Postfix => "#>";

    }
}
