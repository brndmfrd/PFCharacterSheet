namespace ActiveCharacter
{
    public class BasicInformation : MyPropertyChangedEventHandler
    {
        private string _name;
        private string _value;

        public string Name { get { return _name; } set { _name = value; RaisePropertyChanged("Name"); } }
        public string Value { get { return _value; } set { _value = value; RaisePropertyChanged("Value"); } }
    }
}
