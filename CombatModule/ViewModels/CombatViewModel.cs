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
            // Get whatever object the user selected
            var targetItem = VmDisplayObjects.FirstOrDefault(i => i.Name == MySelectedObject.Name);

            var result = "0";
                        
            // todo: use a Constants file
            // todo: error checking for nullz
            // Check the object for specific modifiers
            switch (targetItem.Name)
            {
                case "Full Melee Attack":
                    // Should we change from "Full Melee Attack" to "Full Attack"?
                    result = CombatObjects.GetFullAttackRollValues();
                    break;
                case "Bull Rush":
                    // Should we change from "Full Melee Attack" to "Full Attack"?
                    result = (new Random().Next(1, 21) + MyCharacter.Cmb).ToString();
                    break;
                case "Trip":
                    result = (new Random().Next(1, 21) + MyCharacter.Cmb).ToString();
                    break;
                case "Disarm":
                    result = (new Random().Next(1, 21) + MyCharacter.Cmb).ToString();
                    break;
                case "Sunder":
                    result = (new Random().Next(1, 21) + MyCharacter.Cmb).ToString();
                    break;
                case "Reposition":
                    result = (new Random().Next(1, 21) + MyCharacter.Cmb).ToString();
                    break;
                case "Fortitude":
                    result = (new Random().Next(1, 21) + MyCharacter.SavingThrows["Fortitude"].Total).ToString();
                    break;
                case "Reflex":
                    result = (new Random().Next(1, 21) + MyCharacter.SavingThrows["Reflex"].Total).ToString();
                    break;
                case "Will":
                    result = (new Random().Next(1, 21) + MyCharacter.SavingThrows["Will"].Total).ToString();
                    break;
                default:
                    break;
            }

            targetItem.Result = result.ToString();
        }
        #endregion Private Methods

        // Called by other classes when we need up update something in the combat module
        public void RaisePropertyChangedInCombat()
        {
            RaisePropertyChangedEvent("VmDisplayObjects");
        }

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
