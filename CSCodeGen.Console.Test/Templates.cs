using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSCodeGen
{
    class Templates
    {
        public string Inhalt { get; set; }

        public Templates(string inhalt)
        {
            Inhalt = inhalt;
        }

        public string ErsetzePlatzhalter(Dictionary<string, string> ersetzungen)
        {
            string pattern = @"\b(\w+)\b"; // Jedes einzelne Wort als Platzhalter
            return Regex.Replace(Inhalt, pattern, match =>
            {
                string key = match.Value;
                return ersetzungen.ContainsKey(key) ? ersetzungen[key] : key;
            });
        }
    }

    class Platzhalter
    {
        public Dictionary<string, string> Werte { get; private set; } = new Dictionary<string, string>();

        public void Hinzufügen(string platzhalter, string wert)
        {
            Werte[platzhalter] = wert;
        }
    }

    class Schlüsselwörter
    {
        public static readonly HashSet<string> ReservierteWörter = new HashSet<string>() { "class", "public", "private", "int", "string" };

        public static bool IstSchlüsselwort(string wort)
        {
            return ReservierteWörter.Contains(wort);
        }
    }
}
