using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskAii
{
    public class GestionnaireTaches
    {
        private List<Tache> taches;

        public GestionnaireTaches()
        {
            taches = new List<Tache>();
        }

        public void AjouterTache(Tache tache)
        {
            taches.Add(tache);
        }

        public bool RetirerTache(Tache tache)
        {
            return taches.Remove(tache);
        }

        public List<Tache> GetTachesAvantDeadline(DateTime deadline)
        {
            return taches.Where(tache => tache.Deadline <= deadline).ToList();
        }

        public List<Tache> GetTachesParImportance()
        {
            return taches.OrderByDescending(tache => tache.Importance).ToList();
        }

    }
}