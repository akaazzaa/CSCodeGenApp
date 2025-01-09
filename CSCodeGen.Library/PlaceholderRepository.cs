using System.Collections.Generic;

namespace CSCodeGen.Library
{
    public class PlaceholderRepository
    {
        public List<Placeholder> GetAllPlaceholder()
        {
            // Hier könnte eine Datenbankabfrage stehen. Wir verwenden für das Beispiel Mock-Daten.
            return new List<Placeholder>
            {
                 new Placeholder("namespace", "namespace <#{namespace}#>\r\n{\r\n    \r\n}"),
                 new Placeholder("Accestype", "public"),
                 new Placeholder("Type", "class"),
                 new Placeholder("classname", "MyClass"),

                 new Placeholder("Properties", "Properties"),

                 new Placeholder("methodname", "MyMethod")
            };
        }
    }
}

