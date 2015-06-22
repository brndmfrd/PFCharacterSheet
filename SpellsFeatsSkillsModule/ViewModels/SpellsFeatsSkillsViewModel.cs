using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
using System.Windows.Input;


namespace SpellsFeatsSkillsModule.ViewModels
{
    public class SpellsFeatsSkillsViewModel : ObservableObject, INavigationAware
    {      
        public string SomeText
        {
            get { return Character.characterName; }
            set
            {
                Character.characterName = value;
                RaisePropertyChangedEvent("SomeText");
            }
        }

        public ICommand ConvertTextCommand
        {
            get { return new DelegateCommand(ConvertText); }
        }

        public void ConvertText()
        {
            SomeText = "SpellsFeatsSkillsViewModel";
        }

        // ------- needed for INavigationAware -------
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // keep our view up to date, even when navigating between views
            RaisePropertyChangedEvent("SomeText");
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

    }
}
