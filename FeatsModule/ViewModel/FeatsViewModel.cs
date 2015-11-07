using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;

namespace FeatsModule.ViewModel
{
    class FeatsViewModel : INavigationAware
    {
        public IEnumerable<Feat> Feats { get { return Character.Feats; } }

        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // If we have no character data load these defaults (for testing purposes only, remove later)
            if (Character.Feats.Count <= 0)
            {
                Character.Feats.Add(new Feat() { Name = "Dodge", Description = "Dodge bonus +2 AC." });
                Character.Feats.Add(new Feat() { Name = "Cleave", Description = "If you hit someone, make another attack." });
                Character.Feats.Add(new Feat() { Name = "Maximize Spell", Description = "Makes your spells bigger." });
            }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation
    }
}
