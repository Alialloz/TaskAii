using System.Collections.ObjectModel;

namespace TaskAii.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<TacheViewModel> Taches { get; set; }

        public MainViewModel()
        {
            // Initialisez et chargez les tâches ici
        }

        // Ajoutez des méthodes pour la gestion des tâches
    }
}