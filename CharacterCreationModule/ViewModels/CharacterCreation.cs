using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveCharacter;
using ModuleTools;
using Microsoft.Practices.Prism.Regions;

namespace CharacterCreationModule.ViewModels
{
    public class CharacterCreation : ObservableObject, INavigationAware
    {
        public IEnumerable<BasicInformation> BasicInformation { get { return Models.NewCharacterContainer.Information; } }
        public IEnumerable<Abilities> Abilities { get { return Models.NewCharacterContainer.AbilityScores; } }
        public IEnumerable<string> Languages { get { return Models.NewCharacterContainer.Languages; } }
        public IEnumerable<CharacterClass> CharacterClasses { get { return Models.NewCharacterContainer.Classes; } }
        public IEnumerable<Item> Items { get { return Models.NewCharacterContainer.Gear; } }
        public IEnumerable<Skill> Skills { get { return Models.NewCharacterContainer.Skills; } }
        public IEnumerable<Feat> Feats { get { return Models.NewCharacterContainer.Feats; } }
        public IEnumerable<Spell> Spells { get { return Models.NewCharacterContainer.Spells; } }


        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // If we have no character data load these defaults (for testing purposes only, remove later)
            if (Models.NewCharacterContainer.Information.Count <= 0)
            {
                Models.NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Character Name", Value = "Duraxis" });
                Models.NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Player Name", Value = "Bryan" });
                Models.NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Size", Value = "M" });
                Models.NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Alignment", Value = "NG" });
                Models.NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Age", Value = "30" });
            }
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation


    }
}
