using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;

namespace SkillsModule.ViewModel
{
    class SkillsViewModel : INavigationAware
    {
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
                Character.Skills.Add(new Skill() { Name = "Acrobatics", Ranks = 15, Description = "It's like tumbling." });
                Character.Skills.Add(new Skill() { Name = "Slight of Hand", Ranks = 7, Description = "Street magician or pickpocket ability." });
                Character.Skills.Add(new Skill() { Name = "Swim", Ranks = 4, Description = "How proficient you are in not drowning." });
            }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation
    }
}
