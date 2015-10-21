using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;

namespace SpellsModule.ViewModel
{
    class SpellsViewModel : INavigationAware
    {
        public IEnumerable<Spell> Spells { get { return Character.Spells; } }

        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // If we have no character data load these defaults (for testing purposes only, remove later)
            if (Character.Spells.Count <= 0)
            {
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
