using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ActiveCharacter;
using ModuleTools;
using LoadCharacter;
using CreateNewCharacter;


namespace StartupScreenModule.ViewModels
{
    public class StartupScreenViewModel : ObservableObject
    {
        public ICommand CreateNewCharacterCommand
        {
            get { return new DelegateCommand(CreateNewCharacter); }
        }

        public ICommand LoadNewCharacterCommand
        {
            get { return new DelegateCommand(LoadNewCharacter); }
        }

        private void CreateNewCharacter()
        {
            
        }

        private void LoadNewCharacter()
        {
            LoadCharacter.LoadCharacter lc = new LoadCharacter.LoadCharacter();
            
        }
    }
}
