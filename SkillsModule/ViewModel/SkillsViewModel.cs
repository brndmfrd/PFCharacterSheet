using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;
using SharedResources.EventHandlers;
using SkillsModule.Model;
using System.Linq;
using System;
using SharedResources.Delegates;
using System.Windows.Input;

namespace SkillsModule.ViewModel
{
    class SkillsViewModel : ObservableObject, INavigationAware
    {
        public IEnumerable<DisplayObject> VmDisplayObjects { get { return SkillObjects.DisplayObjects; } }

        #region Public Methods
        public void RefreshProperties()
        {
            SkillObjects.UpdateDisplayObjects();
            RaisePropertyChangedEvent("Skills");
        }

        /// <summary>
        /// The user-selected object from the view screen.
        /// </summary>
        public DisplayObject MySelectedObject
        {
            get { return SkillObjects.CurrentSelectedObject; }
            set { SkillObjects.CurrentSelectedObject = value; }
        }
        #endregion Public Methods

        #region Commands
        public ICommand RollCheck { get { return new DelegateCommand(PerformRollCheck); } }
        #endregion Commands

        #region Private Methods
        private void PerformRollCheck()
        {
            var targetItem = VmDisplayObjects.FirstOrDefault(i => i.Name == MySelectedObject.Name);
            int bonus;
            var success = int.TryParse(targetItem.Value, out bonus);
            if (!success)
            {
                // failure to parse targetItem.Value
                return;
            }
            var result = (new Random().Next(1, 21) + bonus).ToString();
            targetItem.Result = result;

            RefreshProperties();
        }
        #endregion Private Methods

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
