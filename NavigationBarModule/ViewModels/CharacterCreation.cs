using System.Windows.Input;                 // ICommand
using Microsoft.Practices.Prism.Regions;    // INavigationAware
using ModuleTools;

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

        /// <summary>
        /// This is the heart of our navigation. We 'navigate' by changing the views in the registered regions. 
        /// </summary>
        private void ToCharacter()
        {
            //CharacterCreationModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);          // blank content for region
            //CharacterCreationModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(CharacterCreationModule.Views.CharacterViewPrimary).FullName);
            //CharacterCreationModule.regionManager.RequestNavigate("AuxContentRegion", typeof(CharacterCreationModule.Views.CharacterViewAux).FullName);
        }
        private void ToGear()
        {
            //CharacterCreationModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);         // blank content for region
            //CharacterCreationModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(CharacterCreationModule.Views.GearViewPrimary).FullName);
            //CharacterCreationModule.regionManager.RequestNavigate("AuxContentRegion", typeof(CharacterCreationModule.Views.GearViewAux).FullName);
        }
        private void ToSpells()
        {
            //CharacterCreationModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);         // blank content for region
            //CharacterCreationModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(CharacterCreationModule.View.SpellsViewPrimary).FullName);
            //CharacterCreationModule.regionManager.RequestNavigate("AuxContentRegion", typeof(CharacterCreationModule.View.SpellsViewAux).FullName);
        }
        private void ToFeats()
        {
            //CharacterCreationModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);         // blank content for region
            //CharacterCreationModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(CharacterCreationModule.View.FeatsViewPrimary).FullName);
            //CharacterCreationModule.regionManager.RequestNavigate("AuxContentRegion", typeof(CharacterCreationModule.View.FeatsViewAux).FullName);
        }
        private void ToSkills()
        {
            //CharacterCreationModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);         // blank content for region
            //CharacterCreationModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(CharacterCreationModule.View.SkillsViewPrimary).FullName);
            //CharacterCreationModule.regionManager.RequestNavigate("AuxContentRegion", typeof(CharacterCreationModule.View.SkillsViewAux).FullName);
        }
        private void ToPrimaryNavigation()
        {
            //CharacterCreationModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);
            //CharacterCreationModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(System.Windows.Controls.UserControl).FullName);    // blank content for region
            //CharacterCreationModule.regionManager.RequestNavigate("AuxContentRegion", typeof(System.Windows.Controls.UserControl).FullName);        // blank content for region

            NavigationBarModule.regionManager.RequestNavigate("NavigationBarRegion", typeof(Views.NavigationBarModuleView).FullName);
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
