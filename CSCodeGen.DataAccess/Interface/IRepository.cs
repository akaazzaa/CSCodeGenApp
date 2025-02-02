using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.DataAccess.Repository
{
    public interface IRepository<T>
    {
        // Gibt alle Daten zurück
        List<T> GetAll();

        // Fügt ein neues Element hinzu
        void Add(T item);

        // Entfernt ein Element
        void Remove(T item);

        // Speichert die aktuellen Daten
        void Save();
    }
}
