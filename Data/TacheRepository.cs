using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TaskAii.Data
{
    public class TacheRepository
    {
        private const string FilePath = "taches.json";

        public List<Tache> LoadTaches()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<Tache>>(json);
            }

            return new List<Tache>();
        }

        public void SaveTaches(List<Tache> taches)
        {
            string json = JsonConvert.SerializeObject(taches);
            File.WriteAllText(FilePath, json);
        }

        public void AddTache(Tache tache)
        {
            List<Tache> taches = LoadTaches();
            taches.Add(tache);
            SaveTaches(taches);
        }

        public void RemoveTache(Tache tache)
        {
            List<Tache> taches = LoadTaches();
            taches.Remove(tache);
            SaveTaches(taches);
        }

        public void UpdateTache(Tache tache)
        {
            List<Tache> taches = LoadTaches();
            int index = taches.FindIndex(t => t.Id == tache.Id);
            taches[index] = tache;
            SaveTaches(taches);
        }

        public void RemoveAllTaches()
        {
            SaveTaches(new List<Tache>());
        }
    }
}
