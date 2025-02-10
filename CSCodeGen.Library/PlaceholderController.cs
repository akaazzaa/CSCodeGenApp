using CSCodeGen.DataAccess.Model;
using System.Collections.Generic;

namespace CSCodeGen.Library
{
    public class PlaceholderController
    {
        private readonly Dictionary<string, Placeholder> _placeholders;

        public PlaceholderController()
        {
            _placeholders = new Dictionary<string, Placeholder>()
            {

            }
        }

        // Füge einen neuen Platzhalter hinzu oder aktualisiere ihn, wenn er schon existiert
        public void AddOrUpdatePlaceholder(string name, string defaultValue = "", string switchPoint = "")
        {
            if (_placeholders.ContainsKey(name))
            {
                // Wenn der Platzhalter bereits existiert, aktualisiere ihn
                _placeholders[name].DefaultValue = defaultValue;
                _placeholders[name].SwitchPoint = switchPoint;
            }
            else
            {
                // Wenn der Platzhalter noch nicht existiert, füge einen neuen hinzu
                _placeholders[name] = new Placeholder(name, defaultValue, switchPoint);
            }
        }

        // Entferne einen Platzhalter
        public bool RemovePlaceholder(string name)
        {
            return _placeholders.Remove(name);
        }

        // Hole einen Platzhalter nach Name
        public Placeholder GetPlaceholder(string name)
        {
            _placeholders.TryGetValue(name, out var placeholder);
            return placeholder;
        }

        // Gib alle Platzhalter zurück
        public Dictionary<string, Placeholder> GetAllPlaceholders()
        {
            return new Dictionary<string, Placeholder>(_placeholders);
        }
    }

}

