using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
using ModuleTools;
using System.Linq; // keep 


namespace CharacterModule.ViewModels
{
    public class CharacterViewModel : ObservableObject, INavigationAware
    {
        public IEnumerable<BasicInformation> BasicInformation { get { return Character.Information; }}
        public IEnumerable<Abilities> AbilityScores { get { return Character.AbilityScores; } }
        public IEnumerable<string> Languages { get { return Character.Languages; } }
        public IEnumerable<CharacterClass> Classes { get { return Character.Classes; } }
        public int PrimaryDisplayCount{get; private set;}
        

        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // If we have no character data load these defaults (for testing purposes only, remove later)
            if (ActiveCharacter.Character.Information.Count <= 0)
            {               
                Character.Information.Add(new BasicInformation() { Name = "Character Name", Value = "Duraxis" });
                Character.Information.Add(new BasicInformation() { Name = "Player Name", Value = "Bryan" });
                Character.Information.Add(new BasicInformation() { Name = "Size", Value = "M" });
                Character.Information.Add(new BasicInformation() { Name = "Alignment", Value = "NG" });
                Character.Information.Add(new BasicInformation() { Name = "Age", Value = "30" });
                Character.Information.Add(new BasicInformation() { Name = "Race", Value = "Human" });
                Character.Information.Add(new BasicInformation() { Name = "Deity", Value = "Pelor" });
                Character.Information.Add(new BasicInformation() { Name = "Gender", Value = "M" });
                Character.Information.Add(new BasicInformation() { Name = "Height", Value = "6" });
                Character.Information.Add(new BasicInformation() { Name = "Weight", Value = "220" });
                Character.Information.Add(new BasicInformation() { Name = "Eye Color", Value = "Black" });
                Character.Information.Add(new BasicInformation() { Name = "Hair Color", Value = "Black" });
                Character.Information.Add(new BasicInformation() { Name = "Homeland", Value = "Where the heartland is" });
                Character.Information.Add(new BasicInformation() { Name = "Experience Points", Value = "220,000" });
                Character.Information.Add(new BasicInformation() { Name = "Hit Points", Value = "179" });
                Character.Languages.Add("Common");
                Character.AbilityScores.Add(new Abilities() { Name = "Strength", Value = 8 });
                Character.AbilityScores.Add(new Abilities() { Name = "Dextarity", Value = 9 });
                Character.AbilityScores.Add(new Abilities() { Name = "Constitution", Value = 11 });
                Character.AbilityScores.Add(new Abilities() { Name = "Intelligence", Value = 18 });
                Character.AbilityScores.Add(new Abilities() { Name = "Wisdom", Value = 14 });
                Character.AbilityScores.Add(new Abilities() { Name = "Charisma", Value = 6 });
            }
            else
            {
                //Character.Information.Add(new BasicInformation() { Name = "Character Name", Value = "Duraxis" });
                //Character.Information.Add(new BasicInformation() { Key = "Cool-Guy Points", Value = "" });
                // For testing!!!
                var item = BasicInformation.FirstOrDefault(i => i.Name == "Character Name");
                if (item != null)
                {
                    System.Random r = new System.Random();

                    if (0 == r.Next(0, 2))
                    {
                        item.Value = "Duraxis";
                    }
                    else
                    {
                        item.Value = "pappy";
                    }

                }
                
            }

            // Keep the count up to date. 
            //PrimaryDisplayCount = Character.Information.Count + Character.AbilityScores.Count;
            //RaisePropertyChangedEvent("PrimaryDisplayCount");
            
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation0


    }
}
