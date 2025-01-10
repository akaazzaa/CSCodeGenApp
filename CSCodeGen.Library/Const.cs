using System.IO;

namespace CSCodeGen.Library
{
    public class Const
    {
        private static string dataPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Templates";
        private static string dataName = $"Template.json";

        public static string GetFullPath()
        {
            return Path.Combine(dataPath, dataName);
        }
    }
}
