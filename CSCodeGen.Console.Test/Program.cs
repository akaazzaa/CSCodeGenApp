using System;

namespace CSCodeGen
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Ursprüngliches Template mit variablen Wörtern
            string text = "<sourceTyp> <className> " +
                "{ " +
                "       <zugriff> <type> <variablenName>; " +
                "}";

            // Erstelle ein Template-Objekt
            Templates template = new Templates(text);

            // Erstelle Platzhalter und füge Ersetzungen hinzu
            Platzhalter ersetzungen = new Platzhalter();
            ersetzungen.Hinzufügen("<sourceTyp>", "class");
            ersetzungen.Hinzufügen("<className>", "Person");
            ersetzungen.Hinzufügen("<zugriff>", "private");
            ersetzungen.Hinzufügen("<type>", "string");
            ersetzungen.Hinzufügen("<variablenName>", "FirstName");

            // Ersetze Platzhalter und erhalte den finalen Code
            template.ErsetzePlatzhalter(ersetzungen.Werte);

            // Ausgabe
            Console.WriteLine(template.Inhalt);

            Console.Read();


        }
    }
}
