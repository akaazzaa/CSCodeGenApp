using System.Collections.Generic;

namespace CSCodeGen
{
    class Templates
    {
        public string Inhalt { get; set; }



        public Templates(string inhalt)
        {
            Inhalt = inhalt;

        }

        public void ErsetzePlatzhalter(Dictionary<string, string> werte)
        {
            foreach (var wert in werte)
            {
                if (Inhalt.Contains(wert.Key))
                {
                    Inhalt = Inhalt.Replace(wert.Key, wert.Value);
                }
            }
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
