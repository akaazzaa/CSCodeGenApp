using System.IO;

namespace CSCodeGen.DataAccess.Model.Storage
{
    public class ClassFileRepository 
    {
        private readonly string _folderPath;

        public ClassFileRepository(string folderPath)
        {
            _folderPath = folderPath;
            // Stelle sicher, dass der Ordner existiert
            Directory.CreateDirectory(folderPath);
        }

        public void SaveClass(string className, string classContent)
        {
            string filePath = Path.Combine(_folderPath, className + ".cs");
            File.WriteAllText(filePath, classContent);
        }

        public string LoadClass(string className)
        {
            string filePath = Path.Combine(_folderPath, className + ".cs");
            return File.Exists(filePath) ? File.ReadAllText(filePath) : null;
        }
    }
}
