using System;

namespace TaskAii
{
    public class Tache
    {
        public string Nom { get; set; }
        public TimeSpan Duree { get; set; }
        public int Importance { get; set; } // Could be represented on a scale, e.g., 1-5
        public DateTime Deadline { get; set; }
        public string Prerecquis { get; set; }

        public Task(string nom, TimeSpan duree, int importance, DateTime deadline, string prerecquis)
        {
            Nom = nom;
            Duree = duree;
            Importance = importance;
            Deadline = deadline;
            Prerecquis = prerecquis;
        }

        // Additional methods like UpdateTask, CompleteTask etc. can be added here.
    }
}
