using Microsoft.Practices.Prism.Regions;
using System.Linq;
using System;
using SharedResources.Delegates;
using SharedResources.EventHandlers;
using System.Collections.Generic;
using CharacterDataObjects;
using CombatModule.Model;
using System.Windows.Input;

namespace CombatModule.ViewModels
{
    public class CombatViewModel : ObservableObject, INavigationAware
    {
        #region Properties
        /// <summary>
        /// The assembled list of all objects used for this module.
        /// These values are derived from the values contained in 'MyCharacter.cs', the current character data.
        /// </summary>
        public IEnumerable<DisplayObject> VmDisplayObjects
        {
            get { return CombatObjects.displayObjects; }
        }

        /// <summary>
        /// Assumed to be the user-selected object in the Combat view screen.
        /// These are the 'VmDisplayObjects' presented to the user.
        /// i.e. HP, Bull Rush, Fortitude, etc.
        /// </summary>
        public DisplayObject MySelectedObject
        {
            get { return CombatObjects.CurrentSelectedObject; }
            set { CombatObjects.CurrentSelectedObject = value; }
        }
        #endregion Properties

        #region Commands
        public ICommand RollCheck { get { return new DelegateCommand(PerformRollCheck); } }
        #endregion Commands

        #region Private Methods
        private void PerformRollCheck()
        {
            // Get whatever object the user selected
            var targetItem = VmDisplayObjects.FirstOrDefault(i => i.Name == MySelectedObject.Name);

            var result = "0";
                        
            // todo: Use Constants
            // todo: error checking for nullz
            // Check the object for specific modifiers (enchantments, feats, etc)
            switch (targetItem.Name)
            {
                case "Full Melee Attack":
                    // Should we change from "Full Melee Attack" to "Full Attack"?
                    result = CombatObjects.GetFullAttackRollValues();
                    break;
                case "Bull Rush":
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

        #region Public Methods
        /// <summary>
        /// Tell the combat module to update the objects that are displayed. 
        /// This should be invoked when a dependant value changes and needs to be updated immediatly
        /// in the Combat UI.
        /// </summary>
        public void RaisePropertyChangedInCombat()
        {
            RaisePropertyChangedEvent("VmDisplayObjects");
        }
        #endregion Public Methods

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
