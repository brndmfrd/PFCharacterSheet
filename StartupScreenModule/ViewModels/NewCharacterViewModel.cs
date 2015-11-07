using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;

namespace OptionsModule.ViewModels
{
    public class NewCharacterViewModel : INavigationAware
    {
        public IDictionary<string, string> NewCharacterData = new Dictionary<string, string>
        {
            {"Player Name","<enter value>"},
            {"Character Name","<enter value>"},
            {"Race","<enter value>"},
            {"Size","<enter value>"},
            {"Alignment","<enter value>"},
            {"Hit Points ","<enter value>"},
            {"Class","<enter value>"},
            {"Equipment","<enter value>"},
            {"Feats","<enter value>"},
            {"Level","<enter value>"},
            {"Spells","<enter value>"},
            {"Special Abilities","<enter value>"},
            {"Skills & Ranks","<enter value>"},
            {"Strength","<enter value>"},
            {"Dextarity","<enter value>"},
            {"Constitution","<enter value>"},
            {"Intelligence","<enter value>"},
            {"Wisdom","<enter value>"},
            {"Charisma","<enter value>"}
        };

        #region Navigation
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
        #endregion Navigation
    }
}
