using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;                 // ICommand
using Microsoft.Practices.Prism.Regions;    // INavigationAware


namespace NavigationBarModule.ViewModels
{
    /// <summary>
    /// The controls for navigation
    /// </summary>
    public class NavigationBarModuleViewModel : INavigationAware
    {
        /// <summary>
        /// button press Commands
        /// </summary>
        public ICommand NavigateToCharacter
        {
            get { return new RelayCommand(ToCharacter); }
        }
        public ICommand NavigateToCharacter
        {
            get { return new RelayCommand(ToCombat); }
        }
        public ICommand NavigateToCharacter
        {
            get { return new RelayCommand(ToGear); }
        }
        public ICommand NavigateToCharacter
        {
            get { return new RelayCommand(ToSpellsFeatsAndSkills); }
        }

        /// <summary>
        /// Command Actions
        /// </summary>
        private void ToCharacter()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(CharacterModule.Views.CharacterView).FullName);
        }
        private void ToCombat()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(CombatModule.Views.CharacterView).FullName);
        }
        private void ToGear()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(GearModule.Views.CharacterView).FullName);
        }
        private void ToSpellsFeatsAndSkills()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(SpellsFeatsSkillsModule.Views.CharacterView).FullName);
        }


        // ------- needed for INavigationAware -------
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

    }
}
