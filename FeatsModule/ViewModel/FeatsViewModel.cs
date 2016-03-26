using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;
using SharedResources.EventHandlers;
using FeatsModule.Model;

namespace FeatsModule.ViewModel
{
    class FeatsViewModel : ObservableObject, INavigationAware
    {
        public IEnumerable<DisplayObject> Feats { get { return FeatObjects.Feats; } }

        // Listbox in primary view uses this accessor for what is has currently selected
        // Navigation allows the Aux view to 'refresh' and update based on the selected value
        //public Feat MySelectedItem
        //{
        //    get { return SelectedState.CurrentSelectedFeat; }
        //    set { SelectedState.CurrentSelectedFeat = value; 
        //        RaisePropertyChangedEvent("MySelectedItem"); 
        //        FeatsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(View.FeatsViewAux).FullName); 
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
