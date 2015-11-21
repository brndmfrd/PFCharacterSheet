using System.Windows.Input;                 // ICommand
using Microsoft.Practices.Prism.Regions;    // INavigationAware
using ModuleTools;

namespace NavigationBarModule.ViewModels
{
    /// <summary>
    /// The controls for navigation
    /// </summary>
    public class NavigationBarModuleViewModel : ObservableObject, INavigationAware
    {
        /// <summary>
        /// button press Commands
        /// </summary>
        public ICommand NavigateToCharacter
        {
            get { return new DelegateCommand(ToCharacter); }
        }
        public ICommand NavigateToCombat
        {
            get { return new DelegateCommand(ToCombat); }
        }
        public ICommand NavigateToGear
        {
            get { return new DelegateCommand(ToGear); }
        }        
        public ICommand NavigateToSpells
        {
            get { return new DelegateCommand(ToSpells); }
        }
        public ICommand NavigateToFeats
        {
            get { return new DelegateCommand(ToFeats); }
        }
        public ICommand NavigateToSkills
        {
            get { return new DelegateCommand(ToSkills); }
        }
        public ICommand NavigateToOptions
        {
            get { return new DelegateCommand(ToOptions); }
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
        private void ToSpells()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(SpellsModule.View.SpellsView).FullName);
        }
        private void ToFeats()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(FeatsModule.View.FeatsView).FullName);
        }
        private void ToSkills()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(SkillsModule.View.SkillsView).FullName);
        }
        private void ToOptions()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(OptionsModule.Views.OptionsView).FullName);
            
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
