using Microsoft.Practices.Prism.Regions;
using System.Linq;
using System.Timers;
using System.Threading.Tasks;
using System;
using ModuleTools;
using System.Collections.Generic;
using CharacterDataObjects;
using CombatModule.Model;
using System.Windows.Input;

namespace CombatModule.ViewModels
{
    public class CombatViewModel : ObservableObject, INavigationAware
    {
        // The primary display list of combat elements
        public IEnumerable<DisplayObject> VmDisplayObjects { get { return CombatObjects.displayObjects; } }

        public DisplayObject MySelectedObject
        {
            get { return CombatObjects.CurrentSelectedObject; }
            set { CombatObjects.CurrentSelectedObject = value; }
        }

        #region Commands
        public ICommand RollCheck { get { return new DelegateCommand(PerformRollCheck); } }
        #endregion Commands

        #region Private Methods
        private void PerformRollCheck()
        {
            var targetItem = VmDisplayObjects.FirstOrDefault(i => i.Name == MySelectedObject.Name);
            var result = 0;
            // todo: expand this to all cases of all elements in the VmDisplayObjects
            // todo: use a Constants file
            // todo: error checking for nullz
            switch (targetItem.Name)
            {
                case "Fortitude":
                    result = new Random().Next(0, 20) + MyCharacter.SavingThrows["Fortitude"].Total;
                    break;
                default:
                    break;
            }

            targetItem.Result = result.ToString();
            var x = CombatObjects.displayObjects;
            var y = VmDisplayObjects;
        }
        #endregion Private Methods

        #region Navigaion
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
        #endregion Navigaion

    }

   
}
