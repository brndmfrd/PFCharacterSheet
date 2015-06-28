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
        public ICommand NavigateToCombat
        {
            get { return new RelayCommand(ToCombat); }
        }
        public ICommand NavigateToGear
        {
            get { return new RelayCommand(ToGear); }
        }
        public ICommand NavigateToSpellsFeatsSkills
        {
            get { return new RelayCommand(ToSpellsFeatsAndSkills); }
        }
        public ICommand NavigateToStartUpScreen
        {
            get { return new RelayCommand(ToStartUpScreen); }
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
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(CombatModule.Views.CombatView).FullName);
        }
        private void ToGear()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(GearModule.Views.GearView).FullName);
        }
        private void ToSpellsFeatsAndSkills()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(SpellsFeatsSkillsModule.Views.SpellsFeatsSkillsView).FullName);
        }
        private void ToStartUpScreen()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(StartupScreenModule.Views.StartupScreenView).FullName);
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
