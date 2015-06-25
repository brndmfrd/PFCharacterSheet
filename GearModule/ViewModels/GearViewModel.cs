using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
using System.Windows.Input;


namespace GearModule.ViewModels
{
    public class GearViewModel : ObservableObject, INavigationAware
    {
        public string _amount = "0";

        public string Gear
        {
            get { return Character.gear; }
            set
            {
                Character.gear = value;
                RaisePropertyChangedEvent("Gear");
            }
        }

        public string Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                RaisePropertyChangedEvent("Amount");
            }
        }



        // ---------------------------
        public ICommand ChangeGearCommand { get { return new DelegateCommand(UpdateGear); } }
        public ICommand ChangeAmountCommand { get { return new DelegateCommand(UpdateAmount); } }


        // ---------------------------
        public void UpdateGear() { Gear = "Lizard Sabar of Justice"; }
        public void UpdateAmount() { Amount = "42"; }



        // ------- needed for INavigationAware -------
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }        
    }
}
