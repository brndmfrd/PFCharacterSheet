namespace CharacterDataObjects.CharacterDataElements
{
    public class Ability
    {
        private string _name;
        private int _value = 0;
        private int _abilityModifier;
        private int _tempAdjustment;
        private int _tempModifier;

        public string Name { get { return _name; } set { _name = value; } }
        public int Value { get { return _value; } set { _value = value; } }
        public int AbilityModifier
        {
            get
            {
                return (_value / 2) - 5;
            }
        }
        public int TempAdjustment { get { return _tempAdjustment; } set { _tempAdjustment = value; } }
        public int TempModifier { get { return _tempModifier; } set { _tempModifier = value; } }
    }
}
