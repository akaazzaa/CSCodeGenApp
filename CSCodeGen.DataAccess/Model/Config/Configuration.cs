namespace CSCodeGen.DataAccess.Model.Config
{
    public class Configuration
    {
        private static DefaultKeyword keywords = null;
        public  static string CommentPrefix => "//";
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

       

    }
}
