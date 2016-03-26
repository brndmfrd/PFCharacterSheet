using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;
using SharedResources.EventHandlers;
using SkillsModule.Model;

namespace SkillsModule.ViewModel
{
    class SkillsViewModel : ObservableObject, INavigationAware
    {
        public IEnumerable<DisplayObject> Skills { get { return SkillObjects.Skills; } }

        // Listbox in primary view uses this accessor for what is has currently selected
        // Navigation allows the Aux view to 'refresh' and update based on the selected value
        //public Skill MySelectedItem
        //{
        //    get { return SelectedState.CurrentSelectedFeat; }
        //    set
        //    {
        //        SelectedState.CurrentSelectedFeat = value;
        //        RaisePropertyChangedEvent("MySelectedItem");
        //        SkillsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(View.SkillsViewAux).FullName);
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
