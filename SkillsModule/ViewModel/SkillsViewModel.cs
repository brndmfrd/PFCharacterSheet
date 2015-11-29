using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;
using ModuleTools;
using ActiveCharacter;
using SkillsModule.Model;
using SkillsModule.View;

namespace SkillsModule.ViewModel
{
    class SkillsViewModel : ObservableObject, INavigationAware
    {
        public IEnumerable<Skill> Skills { get { return Character.Skills; } }

        // Listbox in primary view uses this accessor for what is has currently selected
        // Navigation allows the Aux view to 'refresh' and update based on the selected value
        public Skill MySelectedItem
        {
            get { return SelectedState.CurrentSelectedFeat; }
            set
            {
                SelectedState.CurrentSelectedFeat = value;
                RaisePropertyChangedEvent("MySelectedItem");
                SkillsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(View.SkillsViewAux).FullName);
            }
        }

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
            RaisePropertyChangedEvent("MySelectedItem");
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation
    }
}
