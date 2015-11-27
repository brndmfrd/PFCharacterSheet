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
        /// This is the heart of our navigation. We 'navigate' by changing the views in the registered regions. 
        /// </summary>
        private void ToCharacter()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);          // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(CharacterModule.Views.CharacterViewControl).FullName);
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(CharacterModule.Views.CharacterViewControl).FullName);
        }
        private void ToCombat()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);         // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(CombatModule.Views.CombatViewControl).FullName);
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(CombatModule.Views.CombatViewControl).FullName);
        }
        private void ToGear()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);         // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(GearModule.Views.GearViewControl).FullName);
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(GearModule.Views.GearViewControl).FullName);
        }
        private void ToSpells()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);         // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(SpellsModule.View.SpellsViewControl).FullName);
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(SpellsModule.View.SpellsViewControl).FullName);
        }
        private void ToFeats()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);         // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(FeatsModule.View.FeatsViewControl).FullName);
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(FeatsModule.View.FeatsViewControl).FullName);
        }
        private void ToSkills()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);         // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(SkillsModule.View.SkillsViewControl).FullName);
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(SkillsModule.View.SkillsViewControl).FullName);
        }
        private void ToOptions()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(OptionsModule.Views.OptionsView).FullName);
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(System.Windows.Controls.UserControl).FullName);    // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(System.Windows.Controls.UserControl).FullName);        // blank content for region
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
