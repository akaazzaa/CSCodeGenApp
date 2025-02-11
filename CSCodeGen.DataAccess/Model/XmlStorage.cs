using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace CSCodeGen.DataAccess.Model
{
    public class XmlStorage
    {
        private readonly string _FolderPath;

        public XmlStorage(string FolderPath)
        {
            _FolderPath = FolderPath;
        }

        public BindingList<Template> LoadAllTemplates()
        {
            // Erstelle eine leere BindingList, in der die geladenen Templates gesammelt werden
            BindingList<Template> templates = new BindingList<Template>();

            // Suche nur nach XML-Dateien im angegebenen Ordner
            string[] files = Directory.GetFiles(_FolderPath, "*.xml");

            // Erstelle einen XmlSerializer für das Template-Objekt
            XmlSerializer serializer = new XmlSerializer(typeof(Template));

            // Durchlaufe alle gefundenen Dateien
            foreach (string file in files)
            {
                try
                {
                    // Öffne die Datei zum Lesen
                    using (StreamReader reader = new StreamReader(file))
                    {
                        // Deserialisiere das Template-Objekt
                        Template template = (Template)serializer.Deserialize(reader);

                        // Falls das Deserialisieren erfolgreich war, füge das Template der Liste hinzu
                        if (template != null)
                        {
                            templates.Add(template);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hier kannst du den Fehler protokollieren oder eine entsprechende Meldung anzeigen
                    Console.WriteLine($"Fehler beim Laden der Datei '{file}': {ex.Message}");
                }
            }

            return templates;
        }

        public void SaveAllTemplates(BindingList<Template> templates)
        {
            // Erstelle einen XmlSerializer für den Typ Template
            XmlSerializer serializer = new XmlSerializer(typeof(Template));

            foreach (Template template in templates)
            {
                try
                {
                    // Verwende den Template-Namen als Dateinamen und hänge .xml an
                    string fileName = template.Name + ".xml";
                    // Kombiniere den Ordnerpfad mit dem Dateinamen
                    string filePath = Path.Combine(_FolderPath, fileName);

                    // Öffne einen StreamWriter zum Schreiben in die Datei
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Serialisiere das Template-Objekt in die Datei
                        serializer.Serialize(writer, template);
                    }

                    Console.WriteLine($"Template '{template.Name}' erfolgreich gespeichert.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim Speichern der Datei '{template.Name}': {ex.Message}");
                }
            }
        }

    }
}
