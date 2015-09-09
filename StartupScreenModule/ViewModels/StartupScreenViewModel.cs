using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ActiveCharacter;
using ModuleTools;

namespace StartupScreenModule.ViewModels
{
    public class StartupScreenViewModel : ObservableObject
    {
        public string SomeText
        {
            get { return Character.characterName; }
            set
            {
                Character.characterName = value;
                RaisePropertyChangedEvent("SomeText");
            }
        }

        public ICommand ConvertTextCommand
        {
            get { return new DelegateCommand(ConvertText); }
        }

        public void ConvertText()
        {
            SomeText = "I have been loaded";
        }
    }
}
