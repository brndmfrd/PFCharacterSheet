using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;
using CharacterDataObjects;
using CharacterModule.Model;
using SharedResources.EventHandlers;
using System.Linq;


namespace CharacterModule.ViewModels
{
    public class CharacterViewModel : ObservableObject, INavigationAware
    {
        public IEnumerable<DisplayObject> BasicInformation { get { return CharacterObjects.BasicInfoObjects; } }
        public IEnumerable<DisplayObject> AbilityScores { get { return CharacterObjects.AbilityScores; } }
        public IEnumerable<DisplayObject> JobClasses { get { return CharacterObjects.JobClasses; } }
        public IEnumerable<DisplayObject> BlankSpace { get { return CharacterObjects.BlankSpace; } }
        public IEnumerable<DisplayObject> Languages { get { return CharacterObjects.Languages; } }

        #region Public Methods
        public void RefreshProperties()
        {
            RaisePropertyChangedEvent("BasicInformation");
            RaisePropertyChangedEvent("AbilityScores");
            RaisePropertyChangedEvent("JobClasses");
            RaisePropertyChangedEvent("Languages");
        }
        #endregion Public Methods

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
