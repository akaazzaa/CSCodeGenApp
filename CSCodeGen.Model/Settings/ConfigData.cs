using CSCodeGen.Model.Main;
using NLog;
using System.Xml.Linq;

namespace CSCodeGen.Model.Settings
{
    public static class ConfigData
    {
        private static DefaultText? keywords = null;
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
            new Textbaustein {  Name = DefaultBaustein.Variable, PrefixWithComment = false },
            new Textbaustein {  Name = DefaultBaustein.Methode, PrefixWithComment = false },
            new Textbaustein {  Name = DefaultBaustein.Function, PrefixWithComment = false },
        };
        }


 

        public static void SetupLogConfig()
        {
            var config = new NLog.Config.LoggingConfiguration();


            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "file.txt" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");


            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);


            NLog.LogManager.Configuration = config;
        }

    }
}
