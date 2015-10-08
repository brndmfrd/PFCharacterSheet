﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
using System.Windows.Input;
using ModuleTools;


namespace CombatModule.ViewModels
{
    public class CombatViewModel : ObservableObject, INavigationAware
    {
        private string _weaponAttacks = "noval";

        #region getters_setters
        /// <summary>
        /// We get the list of weapons that a player has `EQUIPED` 
        /// We use this list of weapons (this includes hand-to-hand) to generate the list of WeaponAttacks
        /// </summary>
        public string Weapons
        {
           get;set;
        }

        /// <summary>
        /// Our list of weapon attacks are all combinations of attacks that can be generated by the user selected 
        /// weapon that is selected via drop-down box for the list of equiped weapons
        /// </summary>
        public string WeaponAttacks
        {
            get { return _weaponAttacks; }
            set
            {
                _weaponAttacks = value;
                RaisePropertyChangedEvent("WeaponAttacks");
            }
        }

        public string HitPoints
        {
            get;set;
        }

        public string Initiative
        {
           get;set;
        }

        public string ArmorClass
        {
            get;set;
        }

        public string Fortitude
        {
            get;set;
        }

        public string Reflex
        {
           get;set;
        }

        public string Will
        {
            get;set;
        }

        public string BaseAttackBonus
        {
           get;set;
        }

        public string CMB
        {
           get;set;
        }

        public string CMD
        {
           get;set;
        }

        public string StatusEffect
        {
            get;set;
        }

        public string Encumbrance
        {
           get;set;
        }

        public string Movement_Combat
        {
            get;
            set;
        }
        #endregion


        // ---------------------------
        public ICommand UpdateWeaponsCommand { get { return new DelegateCommand(UpdateWeapons); } }
        public ICommand UpdateWeaponAttacksCommand { get { return new DelegateCommand(UpdateWeaponAttacks); } }
        public ICommand UpdateHitPointsCommand { get { return new DelegateCommand(UpdateHitPoints); } }
        public ICommand UpdateInitiativeCommand { get { return new DelegateCommand(UpdateInitiative); } }
        public ICommand UpdateArmorClassCommand { get { return new DelegateCommand(UpdateArmorClass); } }
        public ICommand UpdateFortitudeCommand { get { return new DelegateCommand(UpdateFortitude); } }
        public ICommand UpdateReflexCommand { get { return new DelegateCommand(UpdateReflex); } }
        public ICommand UpdateWillCommand { get { return new DelegateCommand(UpdateWill); } }
        public ICommand UpdateBaseAttackBonusCommand { get { return new DelegateCommand(UpdateBaseAttackBonus); } }
        public ICommand UpdateCMBCommand { get { return new DelegateCommand(UpdateCMB); } }
        public ICommand UpdateCMDCommand { get { return new DelegateCommand(UpdateCMD); } }
        public ICommand UpdateStatusEffectCommand { get { return new DelegateCommand(UpdateStatusEffect); } }
        public ICommand UpdateEncumbranceCommand { get { return new DelegateCommand(UpdateEncumbrance); } }
        public ICommand UpdateMovement_CombatCommand { get { return new DelegateCommand(UpdateMovement_Combat); } }


        // ---------------------------
        public void UpdateWeapons() { }
        public void UpdateWeaponAttacks() { }
        public void UpdateHitPoints() { HitPoints = "You ded."; }
        public void UpdateInitiative() { }
        public void UpdateArmorClass() { }
        public void UpdateFortitude() { ; }
        public void UpdateReflex() { ; }
        public void UpdateWill() { ; }
        public void UpdateBaseAttackBonus() { ; }
        public void UpdateCMB() { ; }
        public void UpdateCMD() { ; }
        public void UpdateStatusEffect() { ; }
        public void UpdateEncumbrance() { ; }
        public void UpdateMovement_Combat() { ; }

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
