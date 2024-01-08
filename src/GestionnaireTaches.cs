using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskAii
{
    public class GestionnaireTaches
    {
        private List<Tache> taches;
        private List<Tache> tachesCompletees;

        public GestionnaireTaches()
        {
            taches = new List<Tache>();
            tachesCompletees = new List<Tache>();
        }

        public void AjouterTache(Tache tache)
        {
            taches.Add(tache);
        }

        public bool RetirerTache(Tache tache)
        {
            return taches.Remove(tache);
        }

        public bool ModifierTache(string nomTache, TimeSpan nouvelleDuree, int nouvelleImportance, DateTime nouvelleDeadline, string nouveauxPrerequis)
        {
            var tacheAModifier = taches.FirstOrDefault(t => t.Nom == nomTache);

            if (tacheAModifier != null)
            {
                tacheAModifier.Duree = nouvelleDuree;
                tacheAModifier.Importance = nouvelleImportance;
                tacheAModifier.Deadline = nouvelleDeadline;
                tacheAModifier.Prerequis = nouveauxPrerequis;
                return true;
            }
            return false;
        }

        public List<Tache> GetTachesAvantDeadline(DateTime deadline)
        {
            return taches.Where(tache => tache.Deadline <= deadline).ToList();
        }

        public List<Tache> GetTachesParImportance()
        {
            return taches.OrderByDescending(tache => tache.Importance).ToList();
        }

        public bool MarquerCommeCompletee(string nomTache)
        {
            var tacheACompleter = taches.FirstOrDefault(t => t.Nom == nomTache);

            if (tacheACompleter != null)
            {
                taches.Remove(tacheACompleter);
                tachesCompletees.Add(tacheACompleter);
                return true;
            }
            return false;
        }

        public List<Tache> GetTachesCompletees()
        {
            return tachesCompletees;
        }
    }
}
