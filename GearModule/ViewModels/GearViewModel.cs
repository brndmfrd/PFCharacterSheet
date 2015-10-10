using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
using System.Windows.Input;
using ModuleTools;


namespace GearModule.ViewModels
{
    public class GearViewModel : ObservableObject, INavigationAware
    {
        public string _amount = "0";

       



        //// ---------------------------
        //public ICommand ChangeGearCommand { get { return new DelegateCommand(UpdateGear); } }
        //public ICommand ChangeAmountCommand { get { return new DelegateCommand(UpdateAmount); } }
        //public ICommand ChangeGoldCommand { get { return new DelegateCommand(UpdateGold); } }
        //public ICommand ChangeWeaponsCommand { get { return new DelegateCommand(UpdateWeapons); } }
        //public ICommand ChangeArmorCommand { get { return new DelegateCommand(UpdateArmor); } }


        //// ---------------------------
        ////public void UpdateGear() { Gear = "Lizard Sabar of Justice"; }
        ////public void UpdateAmount() { Amount = "42"; }
        ////public void UpdateGold() {Gold = "1000" ; }
        //public void UpdateWeapons() { ; }
        //public void UpdateArmor() { ; }



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
