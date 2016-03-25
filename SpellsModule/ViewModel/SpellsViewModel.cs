using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;
using SharedResources;
using SharedResources.EventHandlers;
using ActiveCharacter;
using SpellsModule.Model;
using SpellsModule.View;

namespace SpellsModule.ViewModel
{
    class SpellsViewModel : ObservableObject, INavigationAware
    {
        public IEnumerable<Spell> Spells { get { return Character.Spells; } }

        // Listbox in primary view uses this accessor for what is has currently selected
        // Navigation allows the Aux view to 'refresh' and update based on the selected value
        public Spell MySelectedItem
        {
            get { return SelectedState.CurrentSelectedSpell; }
            set
            {
                SelectedState.CurrentSelectedSpell = value;
                RaisePropertyChangedEvent("MySelectedItem");
                SpellsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(View.SpellsViewAux).FullName);
            }
        }
        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // If we have no character data load these defaults (for testing purposes only, remove later)
            if (Character.Spells.Count <= 0)
            {
                Character.Spells.Add(new Spell() { Name = "Bigby's Crushing Fist", Description = "A big hand crushes it." });
                Character.Spells.Add(new Spell() { Name = "Mordakeins Disjunktion", Description = "Totally fucks shit up, srsly." });
                Character.Spells.Add(new Spell() { Name = "Teleport", Description = "Now you see me, now you don't.  Abracadabra, holmes." });
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
