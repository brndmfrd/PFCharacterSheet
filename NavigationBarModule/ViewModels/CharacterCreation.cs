using System.Windows.Input;                 // ICommand
using Microsoft.Practices.Prism.Regions;    // INavigationAware
using SharedResources;
using SharedResources.Delegates;
using SharedResources.EventHandlers;

namespace NavigationBarModule.ViewModels
{
    public class CharacterCreation : ObservableObject, INavigationAware
    {
        /// <summary>
        /// button press Commands
        /// </summary>
        public ICommand NavigateToCharacter
        {
            get { return new DelegateCommand(ToCharacter); }
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
        public ICommand LeaveCharacterCreation
        {
            get { return new DelegateCommand(ToPrimaryNavigation); }
        }
        public ICommand NavigateToSetup
        {
            get { return new DelegateCommand(ToSetup); }
        }

        /// <summary>
        /// This is the heart of our navigation. We 'navigate' by changing the views in the registered regions. 
        /// </summary>
        private void ToCharacter()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(CharacterCreationModule.Views.BasicInfo).FullName);
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(System.Windows.Controls.UserControl).FullName);    // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(System.Windows.Controls.UserControl).FullName);        // blank content for region
        }
        private void ToGear()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(CharacterCreationModule.Views.Gear).FullName);
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(System.Windows.Controls.UserControl).FullName);    // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(System.Windows.Controls.UserControl).FullName);        // blank content for region
        }
        private void ToSpells()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(CharacterCreationModule.Views.Spells).FullName);
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(System.Windows.Controls.UserControl).FullName);    // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(System.Windows.Controls.UserControl).FullName);        // blank content for region
        }
        private void ToFeats()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(CharacterCreationModule.Views.Feats).FullName);
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(System.Windows.Controls.UserControl).FullName);    // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(System.Windows.Controls.UserControl).FullName);        // blank content for region
        }
        private void ToSkills()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(CharacterCreationModule.Views.Skills).FullName);
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(System.Windows.Controls.UserControl).FullName);    // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(System.Windows.Controls.UserControl).FullName);        // blank content for region
        }
        private void ToSetup()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(CharacterCreationModule.Views.Setup).FullName);
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(System.Windows.Controls.UserControl).FullName);    // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(System.Windows.Controls.UserControl).FullName);        // blank content for region
        }
        private void ToPrimaryNavigation()
        {
            NavigationBarModule.regionManager.RequestNavigate("NavigationBarRegion", typeof(Views.NavigationBarModuleView).FullName);
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);              // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(OptionsModule.Views.OptionsViewPrimary).FullName);
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(OptionsModule.Views.OptionsViewAux).FullName);        
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
