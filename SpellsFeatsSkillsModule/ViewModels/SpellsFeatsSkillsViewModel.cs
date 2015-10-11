//using System;
using System.Collections.Generic;
//using System.Collections.ObjectModel;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
//using System.Windows.Input;
//using SpellsFeatsSkillsModule.Models;
//using ModuleTools;

namespace SpellsFeatsSkillsModule.ViewModels
{
    public class SpellsFeatsSkillsViewModel : INavigationAware
    {
        public IEnumerable<Spell> Spells { get { return Character.Spells; } }
        public IEnumerable<Feat> Feats { get { return Character.Feats; } }
        public IEnumerable<Skill> Skills { get { return Character.Skills; } }

        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // If we have no character data load these defaults (for testing purposes only, remove later)
            if (Character.Skills.Count <= 0)
            {
                Character.Skills.Add(new Skill() { Name = "Acrobatics", Ranks = 15, Description = "It's like tumbling."});
                Character.Skills.Add(new Skill() { Name = "Slight of Hand", Ranks = 7, Description = "Street magician or pickpocket ability." });
                Character.Skills.Add(new Skill() { Name = "Swim", Ranks = 4, Description = "How proficient you are in not drowning." });

                Character.Feats.Add(new Feat() { Name = "Dodge", Description = "Dodge bonus +2 AC." });
                Character.Feats.Add(new Feat() { Name = "Cleave", Description = "If you hit someone, make another attack." });
                Character.Feats.Add(new Feat() { Name = "Maximize Spell", Description = "Makes your spells bigger."});

                Character.Spells.Add(new Spell() { Name = "Bigby's Crushing Fist", Description = "A big hand crushes it." });
                Character.Spells.Add(new Spell() { Name = "Mordakeins Disjunktion", Description = "Totally fucks shit up, srsly." });
                Character.Spells.Add(new Spell() { Name = "Teleport", Description = "Now you see me, now you don't.  Abracadabra, holmes." });
            }
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation
    }

    
}
