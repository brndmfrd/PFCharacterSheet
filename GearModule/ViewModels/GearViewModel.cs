using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;
using SharedResources.EventHandlers;
using GearModule.Model;


namespace GearModule.ViewModels
{
    public class GearViewModel : ObservableObject, INavigationAware
    {
        public IEnumerable<DisplayObject> Gear { get { return GearObjects.Gear; }}

        #region Public Methods
        public void RefreshProperties()
        {
            RaisePropertyChangedEvent("Gear");
        }
        #endregion Public Methods
        // Listbox in primary view uses this accessor for what is has currently selected
        // Navigation allows the Aux view to 'refresh' and update based on the selected value
        //public Item MySelectedItem
        //{
        //    get { return SelectedState.CurrentSelectedFeat; }
        //    set
        //    {
        //        SelectedState.CurrentSelectedFeat = value;   
        //        GearModule.regionManager.RequestNavigate("AuxContentRegion", typeof(Views.GearViewAux).FullName);
        //    }
        //}

        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            RefreshProperties();
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation
    }
}
