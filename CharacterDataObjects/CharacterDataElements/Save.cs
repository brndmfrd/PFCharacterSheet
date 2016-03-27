namespace CharacterDataObjects.CharacterDataElements
{
    public class Save
    {
        public Save(string _abilityScoreName)
        {
            abilityScoreName = _abilityScoreName;
        }

        private string abilityScoreName;
        private int total = 0;
        private int baseSave = 0;
        private int magicModifier = 0;
        private int miscModifier = 0;
        private int tempModifier = 0;

        public int Total { get { return (total = baseSave + AbilityModifier + magicModifier + miscModifier + tempModifier); } }
        public int BaseSave { get { return baseSave; } set { baseSave = value; } } // base save, for all jobclasses, based on level of each job class, specific to each save (f/r/w)
        public int AbilityModifier { get { return MyCharacter.AbilityScores[abilityScoreName].AbilityModifier; } }
        public int MagicModifier { get { return magicModifier; } set { magicModifier = value; } }
        public int MiscModifier { get { return miscModifier; } set { miscModifier = value; } }
        public int TempModifier { get { return tempModifier; } set { tempModifier = value; } }
    }
}
