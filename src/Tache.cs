using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskAii
{
    public class Tache
    {
        public string Nom { get; set; }
        public TimeSpan Duree { get; set; }
        public int Importance { get; set; }
        public DateTime Deadline { get; set; }
        public string Prerequis { get; set; }
        public List<Tache> SousTaches { get; set; }

        public Tache(string nom, TimeSpan duree, int importance, DateTime deadline, string prerequis)
        {
            Nom = nom;
            Duree = duree;
            Importance = importance;
            Deadline = deadline;
            Prerequis = prerequis;
            SousTaches = new List<Tache>();
        }

        public void AjouterSousTache(Tache sousTache)
        {
            SousTaches.Add(sousTache);
        }

        public void RetirerSousTache(Tache sousTache)
        {
            SousTaches.Remove(sousTache);
        }

        // Calculer la durée totale en incluant les sous-tâches
        public TimeSpan CalculerDureeTotale()
        {
            var dureeTotale = Duree;
            foreach (var sousTache in SousTaches)
            {
                dureeTotale += sousTache.CalculerDureeTotale();
            }
            return dureeTotale;
        }

    }
}
