//using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
//using System.Windows.Input;
//using ModuleTools;
//using System.Collections.ObjectModel;


namespace CharacterModule.ViewModels
{
    public class CharacterViewModel : INavigationAware
    {
        public IEnumerable<BasicInformation> BasicInformation { get { return Character.Information; }}
        public IEnumerable<Abilities> AbilityScores { get { return Character.AbilityScores; } }
        public IEnumerable<string> Languages { get { return Character.Languages; } }
        public IEnumerable<CharacterClass> Classes { get { return Character.Classes; } }

        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // get the data we are interested in from the model
            //CharacterInformation = ActiveCharacter.Character.Information;
            if (ActiveCharacter.Character.Information.Count <= 0)
            {
                Character.Information.Add(new BasicInformation() { Key = "Character Name", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Player Name", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Size", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Alignment", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Age", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Race", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Deity", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Gender", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Height", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Weight", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Eye Color", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Hair Color", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Homeland", Value = "" });
                Character.Information.Add(new BasicInformation() { Key = "Experience Points", Value = "" });
                Character.Languages.Add("Common");
                Character.AbilityScores.Add(new Abilities() { AbilityName = "Strength", Value = 10 });
                Character.AbilityScores.Add(new Abilities() { AbilityName = "Dextarity", Value = 10 });
                Character.AbilityScores.Add(new Abilities() { AbilityName = "Constitution", Value = 10 });
                Character.AbilityScores.Add(new Abilities() { AbilityName = "Intelligence", Value = 10 });
                Character.AbilityScores.Add(new Abilities() { AbilityName = "Wisdom", Value = 10 });
                Character.AbilityScores.Add(new Abilities() { AbilityName = "Charisma", Value = 10 });
            }
            else
            {
                var item = BasicInformation.FirstOrDefault(i => i.Key == "Character Name");
                if (item != null)
                {
                    item.Value = "Duraxis";
                }
                
            }
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation


    }
}
