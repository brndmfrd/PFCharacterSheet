using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterDataObjects.CharacterDataConstants;

namespace CharacterDataObjects.CharacterDataObjects
{
    public class BaseAttackBonus
    {
        // This is where we get the BAB value
        // The individual object does the caluclation from the static data already present.
        public int GetBaseAttackBonus()
        {
            int totalBab = 0;

            // Access the dictionary of all the classes the player currently has 
            // get the BAB from each of them. 
            // Each jobclass has a current BAB derived by the class and level.
            // This will access those values and take the sum. This is our total BAB for the character 
            // (and not just for the individual jobclasses).
            foreach(var jobclass in MyCharacter.JobClasses)
            {
                totalBab += jobclass.Value.BaseAttackBonus;
            }
           
            return totalBab;
        }

    }
}
