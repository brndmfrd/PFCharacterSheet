namespace ActiveCharacter
{
    public class Abilities : MyPropertyChangedEventHandler
    {
        private string _name;
        private ushort _value;

        /// <summary>
        /// Name of the ability
        /// </summary>
        public string Name { get { return _name; } set { _name = value; RaisePropertyChanged("Name"); } }
        /// <summary>
        /// Number of points assigned to the given ability score
        /// </summary>
        public ushort Value { get { return _value; } set { _value = value; RaisePropertyChanged("Value"); } }
    }
}
