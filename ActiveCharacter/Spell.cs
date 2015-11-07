namespace ActiveCharacter
{
    public class Spell : MyPropertyChangedEventHandler
    {
        private string _name;
        private string _decription;
        private string _school;
        private string _castingTime;
        private string _components;
        private string _target;
        private string _range;
        private string _area;
        private string _duration;
        private string _savingThrow;
        private bool _spellResistance;
        private string _level;
        private string _casterLevel;      // if used to enchant an item
        private string _charges;          // if added to an item
        private string _aura;             // if as an enchantment
        //todo: add some standard form for penalties & benifits
        // that can be parsed for combat action e.g.
        // <effected property>, <amount>, <duration>
        // Dextarity, 5, 3 (minutes)
        // <status emparted>, <constraints>, <duration>
        // facination, {2d4 HD, person}, 1 (minute)
        // There could be multiple effects, as well.  e.g.
        // Rage => +St, +Dex, +Con
        // Special defence/attack
        // <bonus>, <conditino>
        // +inf AC, vs magic missle (shield negates magic missle)


        public string Name { get { return _name; } set { _name = value; RaisePropertyChanged("Name"); } }
        public string Description { get { return _decription; } set { _decription = value; RaisePropertyChanged("Decription"); } }
        public string School { get { return _school; } set { _school = value; RaisePropertyChanged("School"); } }
        public string CastingTime { get { return _castingTime; } set { _castingTime = value; RaisePropertyChanged("CastingTime"); } }
        public string Components { get { return _components; } set { _components = value; RaisePropertyChanged("Components"); } }
        public string Target { get { return _target; } set { _target = value; RaisePropertyChanged("Target"); } }
        public string Range { get { return _range; } set { _range = value; RaisePropertyChanged("Range"); } }
        public string Area { get { return _area; } set { _area = value; RaisePropertyChanged("Area"); } }
        public string Duration { get { return _duration; } set { _duration = value; RaisePropertyChanged("Duration"); } }
        public string SavingThrow { get { return _savingThrow; } set { _savingThrow = value; RaisePropertyChanged("SavingThrow"); } }
        public bool SpellResistance { get { return _spellResistance; } set { _spellResistance = value; RaisePropertyChanged("SpellResistance"); } }
        public string Level { get { return _level; } set { _level = value; RaisePropertyChanged("Level"); } }
        public string CasterLevel { get { return _casterLevel; } set { _casterLevel = value; RaisePropertyChanged("CasterLevel"); } }
        public string Charges { get { return _charges; } set { _charges = value; RaisePropertyChanged("Charges"); } }
        public string Aura { get { return _aura; } set { _aura = value; RaisePropertyChanged("Aura"); } }

    }
}
