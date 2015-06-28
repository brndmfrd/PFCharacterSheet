﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
using System.Windows.Input;


namespace CombatModule.ViewModels
{
    public class CombatViewModel : ObservableObject, INavigationAware
    {
        private string _weaponAttacks = "noval";

        /// <summary>
        /// We get the list of weapons that a player has `EQUIPED` 
        /// We use this list of weapons (this includes hand-to-hand) to generate the list of WeaponAttacks
        /// </summary>
        public string Weapons
        {
            get { return Character.weapons; }
            set
            {
                Character.weapons = value;
                RaisePropertyChangedEvent("Weapons");
            }
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
            get { return Character.hitPoints; }
            set
            {
                Character.hitPoints = value;
                RaisePropertyChangedEvent("HitPoints");
            }
        }

        public string Initiative
        {
            get { return Character.initiative; }
            set
            {
                Character.initiative = value;
                RaisePropertyChangedEvent("Initiative");
            }
        }

        public string ArmorClass
        {
            get { return Character.armorClass; }
            set
            {
                Character.armorClass = value;
                RaisePropertyChangedEvent("ArmorClass");
            }
        }

        public string Fortitude
        {
            get { return Character.fortitudeSave; }
            set
            {
                Character.fortitudeSave = value;
                RaisePropertyChangedEvent("Fortitude");
            }
        }

        public string Reflex
        {
            get { return Character.reflexSave; }
            set
            {
                Character.reflexSave = value;
                RaisePropertyChangedEvent("Reflex");
            }
        }

        public string Will
        {
            get { return Character.willSave; }
            set
            {
                Character.willSave = value;
                RaisePropertyChangedEvent("Will");
            }
        }

        public string BaseAttackBonus
        {
            get { return Character.baseAttackBonus; }
            set
            {
                Character.baseAttackBonus = value;
                RaisePropertyChangedEvent("BaseAttackBonus");
            }
        }

        public string CMB
        {
            get { return Character.combatManeuverBonus; }
            set
            {
                Character.combatManeuverBonus = value;
                RaisePropertyChangedEvent("CMB");
            }
        }

        public string CMD
        {
            get { return Character.combatManeuverDefence; }
            set
            {
                Character.combatManeuverDefence = value;
                RaisePropertyChangedEvent("CMD");
            }
        }

        public string StatusEffect
        {
            get { return Character.statusEffect; }
            set
            {
                Character.statusEffect = value;
                RaisePropertyChangedEvent("StatusEffect");
            }
        }

        public string Encumbrance
        {
            get { return Character.encumbrance; }
            set
            {
                Character.encumbrance = value;
                RaisePropertyChangedEvent("Encumbrance");
            }
        }

        public string Movement_Combat
        {
            get { return Character.movement_combat; }
            set
            {
                Character.movement_combat = value;
                RaisePropertyChangedEvent("Movement_Combat");
            }
        }


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
