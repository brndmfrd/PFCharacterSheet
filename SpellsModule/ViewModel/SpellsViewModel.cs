using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;
using SharedResources.EventHandlers;
using SpellsModule.Model;

namespace SpellsModule.ViewModel
{
    class SpellsViewModel : ObservableObject, INavigationAware
    {
        public IEnumerable<DisplayObject> Spells { get { return SpellObjects.Spells; } }

        // Listbox in primary view uses this accessor for what is has currently selected
        // Navigation allows the Aux view to 'refresh' and update based on the selected value
        //public Spell MySelectedItem
        //{
        //    get { return SelectedState.CurrentSelectedSpell; }
        //    set
        //    {
        //        SelectedState.CurrentSelectedSpell = value;
        //        RaisePropertyChangedEvent("MySelectedItem");
        //        SpellsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(View.SpellsViewAux).FullName);
        //    }
        //}
        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation
    }
}
