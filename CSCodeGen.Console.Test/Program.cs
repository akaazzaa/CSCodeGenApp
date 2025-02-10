using System;

namespace CSCodeGen
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Ursprüngliches Template mit variablen Wörtern
            string text = "class Name { public string Wert; }";

            // Erstelle ein Template-Objekt
            Templates template = new Templates(text);

            // Erstelle Platzhalter und füge Ersetzungen hinzu
            Platzhalter ersetzungen = new Platzhalter();
            ersetzungen.Hinzufügen("Name", "Person");
            ersetzungen.Hinzufügen("Wert", "FirstName");

            // Ersetze Platzhalter und erhalte den finalen Code
            string finalerCode = template.ErsetzePlatzhalter(ersetzungen.Werte);

            // Ausgabe
            Console.WriteLine(finalerCode);

            Console.Read();


        }
    }
}
