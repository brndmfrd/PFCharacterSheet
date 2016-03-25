using System;
using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
using SharedResources;
using SharedResources.EventHandlers;
using FeatsModule.Model;
using System.Linq;
using System.Windows.Input;
using FeatsModule.View;

namespace FeatsModule.ViewModel
{
    class FeatsViewModel : ObservableObject, INavigationAware
    {
        public IEnumerable<Feat> Feats { get { return Character.Feats; } }

        // Listbox in primary view uses this accessor for what is has currently selected
        // Navigation allows the Aux view to 'refresh' and update based on the selected value
        public Feat MySelectedItem
        {
            get { return SelectedState.CurrentSelectedFeat; }
            set { SelectedState.CurrentSelectedFeat = value; 
                RaisePropertyChangedEvent("MySelectedItem"); 
                FeatsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(View.FeatsViewAux).FullName); 
            }
        }

        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // If we have no character data load these defaults (for testing purposes only, remove later)
            if (Character.Feats.Count <= 0)
            {
                Character.Feats.Add(new Feat() { Name = "Dodge", Description = "Dodge bonus +2 AC." });
                Character.Feats.Add(new Feat() { Name = "Cleave", Description = "If you hit someone, make another attack." });
                Character.Feats.Add(new Feat() { Name = "Maximize Spell", Description = "Makes your spells bigger." });
            }

            RaisePropertyChangedEvent("MySelectedItem");
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation
    }
}
