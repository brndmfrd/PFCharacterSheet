using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
using System.Windows.Input;
using SpellsFeatsSkillsModule.Models;

namespace SpellsFeatsSkillsModule.ViewModels
{
    public class SpellsFeatsSkillsViewModel : ObservableObject, INavigationAware
    {
        // -- Skills --
        public int Acrobatics { get { return SkillModel.Acrobatics; } set { SkillModel.Acrobatics = value; RaisePropertyChangedEvent("Acrobatics"); } }
        public int Appraise { get { return SkillModel.Appraise; } set { SkillModel.Appraise = value; RaisePropertyChangedEvent("Appraise");} }
        public int Bluff { get { return SkillModel.Bluff; } set { SkillModel.Bluff = value; RaisePropertyChangedEvent("Bluff"); } }
        public int Climb { get { return SkillModel.Climb; } set { SkillModel.Climb = value; RaisePropertyChangedEvent("Climb"); } }
        public int Craft { get { return SkillModel.Craft; } set { SkillModel.Craft = value; RaisePropertyChangedEvent("Craft"); } }
        public int Diplomacy { get { return SkillModel.Diplomacy; } set { SkillModel.Diplomacy = value; RaisePropertyChangedEvent("Diplomacy"); } }
        public int DisableDevice { get { return SkillModel.DisableDevice; } set { SkillModel.DisableDevice = value; RaisePropertyChangedEvent("DisableDevice"); } }
        public int Disguise { get { return SkillModel.Disguise; } set { SkillModel.Disguise = value; RaisePropertyChangedEvent("Disguise"); } }
        public int EscapeArtist { get { return SkillModel.EscapeArtist; } set { SkillModel.EscapeArtist = value; RaisePropertyChangedEvent("EscapeArtist"); } }
        public int Fly { get { return SkillModel.Fly; } set { SkillModel.Fly = value; RaisePropertyChangedEvent("Fly"); } }
        public int HandleAnimal { get { return SkillModel.HandleAnimal; } set { SkillModel.HandleAnimal = value; RaisePropertyChangedEvent("HandleAnimal"); } }
        public int Heal { get { return SkillModel.Heal; } set { SkillModel.Heal = value; RaisePropertyChangedEvent("Heal"); } }
        public int Intimidate { get { return SkillModel.Intimidate; } set { SkillModel.Intimidate = value; RaisePropertyChangedEvent("Intimidate"); } }
        public int KnowledgeArcana { get { return SkillModel.KnowledgeArcana; } set { SkillModel.KnowledgeArcana = value; RaisePropertyChangedEvent("KnowledgeArcana"); } }
        public int KnowledgeDungeoneering { get { return SkillModel.KnowledgeDungeoneering; } set { SkillModel.KnowledgeDungeoneering = value; RaisePropertyChangedEvent("KnowledgeDungeoneering"); } }
        public int KnowledgeEngineering { get { return SkillModel.KnowledgeEngineering; } set { SkillModel.KnowledgeEngineering = value; RaisePropertyChangedEvent("KnowledgeEngineering"); } }
        public int KnowledgeGeography { get { return SkillModel.KnowledgeGeography; } set { SkillModel.KnowledgeGeography = value; RaisePropertyChangedEvent("KnowledgeGeography"); } }
        public int KnowledgeHistory { get { return SkillModel.KnowledgeHistory; } set { SkillModel.KnowledgeHistory = value; RaisePropertyChangedEvent("KnowledgeHistory"); } }
        public int KnowledgeLocal { get { return SkillModel.KnowledgeLocal; } set { SkillModel.KnowledgeLocal = value; RaisePropertyChangedEvent("KnowledgeLocal"); } }
        public int KnowledgeNature { get { return SkillModel.KnowledgeNature; } set { SkillModel.KnowledgeNature = value; RaisePropertyChangedEvent("KnowledgeNature"); } }
        public int KnowledgeNobility { get { return SkillModel.KnowledgeNobility; } set { SkillModel.KnowledgeNobility = value; RaisePropertyChangedEvent("KnowledgeNobility"); } }
        public int KnowledgePlanes { get { return SkillModel.KnowledgePlanes; } set { SkillModel.KnowledgePlanes = value; RaisePropertyChangedEvent("KnowledgePlanes"); } }
        public int KnowledgeReligion { get { return SkillModel.KnowledgeReligion; } set { SkillModel.KnowledgeReligion = value; RaisePropertyChangedEvent("KnowledgeReligion"); } }
        public int Linguistics { get { return SkillModel.Linguistics; } set { SkillModel.Linguistics = value; RaisePropertyChangedEvent("Linguistics"); } }
        public int Perception { get { return SkillModel.Perception; } set { SkillModel.Perception = value; RaisePropertyChangedEvent("Perception"); } }
        public int Perform { get { return SkillModel.Perform; } set { SkillModel.Perform = value; RaisePropertyChangedEvent("Perform"); } }
        public int Profession { get { return SkillModel.Profession; } set { SkillModel.Profession = value; RaisePropertyChangedEvent("Profession"); } }
        public int Ride { get { return SkillModel.Ride; } set { SkillModel.Ride = value; RaisePropertyChangedEvent("Ride"); } }
        public int SenseMotive { get { return SkillModel.SenseMotive; } set { SkillModel.SenseMotive = value; RaisePropertyChangedEvent("SenseMotive"); } }
        public int SleightOfHand { get { return SkillModel.SleightOfHand; } set { SkillModel.SleightOfHand = value; RaisePropertyChangedEvent("SleightOfHand"); } }
        public int Spellcraft { get { return SkillModel.Spellcraft; } set { SkillModel.Spellcraft = value; RaisePropertyChangedEvent("Spellcraft"); } }
        public int Stealth { get { return SkillModel.Stealth; } set { SkillModel.Stealth = value; RaisePropertyChangedEvent("Stealth"); } }
        public int Survival { get { return SkillModel.Survival; } set { SkillModel.Survival = value; RaisePropertyChangedEvent("Survival"); } }
        public int Swim { get { return SkillModel.Swim; } set { SkillModel.Swim = value; RaisePropertyChangedEvent("Swim"); } }
        public int UseMagicDevice { get { return SkillModel.UseMagicDevice; } set { SkillModel.UseMagicDevice = value; RaisePropertyChangedEvent("UseMagicDevice"); } }
              

        // -- Feats --
        private void FillFeats()
        {
            feats.Add("Dodge");
            feats.Add("Power Attack");
            feats.Add("Mobility");
            feats.Add("Craft Magical Arms");
            feats.Add("Empower Spell");
        }
        private readonly ObservableCollection<string> feats = new ObservableCollection<string>();
        public IEnumerable<string> FeatsName { get { return feats; } }
        //private void AddToFeats(string foot) { feats.Add(foot); }
        private void AddToFeats() { feats.Add("hey"); }
        //private void RemoveFromFeats(string foot) { feats.Remove(foot); }
        public ICommand AddToFeatsCommand{get{return new DelegateCommand(AddToFeats);}}
        // We will need to pass parameters from the view (what feat to remove)

        // -- Spells -- 
        private void FillSpells()
        {
            spells.Add("Create Water");
            spells.Add("Bigbys Crushing Fist");
            spells.Add("Magic Missle");
            spells.Add("Bigbys Iced Mocha Mocha");
            spells.Add("Limited Wish");
        }
        private readonly ObservableCollection<string> spells = new ObservableCollection<string>();
        public IEnumerable<string> SpellsName { get { return spells; } }
        //private void AddToFeats(string foot) { feats.Add(foot); }
        private void AddToSpells() { spells.Add("hey"); }
        //private void RemoveFromFeats(string foot) { feats.Remove(foot); }
        public ICommand AddToSpellsCommand { get { return new DelegateCommand(AddToSpells); } }
        // We will need to pass parameters from the view (what feat to remove)


        // -------- Command ------------
        public ICommand UpdateAcrobaticsCommand { get { return new DelegateCommand(UpdateAcrobatics); } }
        public ICommand UpdateAppraiseCommand { get { return new DelegateCommand(UpdateAppraise); } }
        public ICommand UpdateBluffCommand { get { return new DelegateCommand(UpdateBluff); } }
        public ICommand UpdateClimbCommand { get { return new DelegateCommand(UpdateClimb); } }
        public ICommand UpdateCraftCommand { get { return new DelegateCommand(UpdateCraft); } }
        public ICommand UpdateDiplomacyCommand { get { return new DelegateCommand(UpdateDiplomacy); } }
        public ICommand UpdateDisableDeviceCommand { get { return new DelegateCommand(UpdateDisableDevice); } }
        public ICommand UpdateDisguiseCommand { get { return new DelegateCommand(UpdateDisguise); } }
        public ICommand UpdateEscapeArtistCommand { get { return new DelegateCommand(UpdateEscapeArtist); } }
        public ICommand UpdateFlyCommand { get { return new DelegateCommand(UpdateFly); } }
        public ICommand UpdateHandleAnimalCommand { get { return new DelegateCommand(UpdateHandleAnimal); } }
        public ICommand UpdateHealCommand { get { return new DelegateCommand(UpdateHeal); } }
        public ICommand UpdateIntimidateCommand { get { return new DelegateCommand(UpdateIntimidate); } }
        public ICommand UpdateKnowledgeArcanaCommand { get { return new DelegateCommand(UpdateKnowledgeArcana); } }
        public ICommand UpdateKnowledgeDungeoneeringCommand { get { return new DelegateCommand(UpdateKnowledgeDungeoneering); } }
        public ICommand UpdateKnowledgeEngineeringCommand { get { return new DelegateCommand(UpdateKnowledgeEngineering); } }
        public ICommand UpdateKnowledgeGeographyCommand { get { return new DelegateCommand(UpdateKnowledgeGeography); } }
        public ICommand UpdateKnowledgeHistoryCommand { get { return new DelegateCommand(UpdateKnowledgeHistory); } }
        public ICommand UpdateKnowledgeLocalCommand { get { return new DelegateCommand(UpdateKnowledgeLocal); } }
        public ICommand UpdateKnowledgeNatureCommand { get { return new DelegateCommand(UpdateKnowledgeNature); } }
        public ICommand UpdateKnowledgeNobilityCommand { get { return new DelegateCommand(UpdateKnowledgeNobility); } }
        public ICommand UpdateKnowledgePlanesCommand { get { return new DelegateCommand(UpdateKnowledgePlanes); } }
        public ICommand UpdateKnowledgeReligionCommand { get { return new DelegateCommand(UpdateKnowledgeReligion); } }
        public ICommand UpdateLinguisticsCommand { get { return new DelegateCommand(UpdateLinguistics); } }
        public ICommand UpdatePerceptionCommand { get { return new DelegateCommand(UpdatePerception); } }
        public ICommand UpdatePerformCommand { get { return new DelegateCommand(UpdatePerform); } }
        public ICommand UpdateProfessionCommand { get { return new DelegateCommand(UpdateProfession); } }
        public ICommand UpdateRideCommand { get { return new DelegateCommand(UpdateRide); } }
        public ICommand UpdateSenseMotiveCommand { get { return new DelegateCommand(UpdateSenseMotive); } }
        public ICommand UpdateSleightOfHandCommand { get { return new DelegateCommand(UpdateSleightOfHand); } }
        public ICommand UpdateSpellcraftCommand { get { return new DelegateCommand(UpdateSpellcraft); } }
        public ICommand UpdateStealthCommand { get { return new DelegateCommand(UpdateStealth); } }
        public ICommand UpdateSurvivalCommand { get { return new DelegateCommand(UpdateSurvival); } }
        public ICommand UpdateSwimCommand { get { return new DelegateCommand(UpdateSwim); } }
        public ICommand UpdateUseMagicDeviceCommand { get { return new DelegateCommand(UpdateUseMagicDevice); } }


        // ---------- Update ----------
        public void UpdateAcrobatics() { Acrobatics = 1; }
        public void UpdateAppraise() { Appraise = 1; }
        public void UpdateBluff() { Bluff = 1; }
        public void UpdateClimb() { Climb = 1; }
        public void UpdateCraft() { Craft = 1; }
        public void UpdateDiplomacy() { Diplomacy = 1; }
        public void UpdateDisableDevice() { DisableDevice = 1; }
        public void UpdateDisguise() { Disguise = 1; }
        public void UpdateEscapeArtist() { EscapeArtist = 1; }
        public void UpdateFly() { Fly = 1; }
        public void UpdateHandleAnimal() { HandleAnimal = 1; }
        public void UpdateHeal() { Heal = 1; }
        public void UpdateIntimidate() { Intimidate = 1; }
        public void UpdateKnowledgeArcana() { KnowledgeArcana = 1; }
        public void UpdateKnowledgeDungeoneering() { KnowledgeDungeoneering = 1; }
        public void UpdateKnowledgeEngineering() { KnowledgeEngineering = 1; }
        public void UpdateKnowledgeGeography() { KnowledgeGeography = 1; }
        public void UpdateKnowledgeHistory() { KnowledgeHistory = 1; }
        public void UpdateKnowledgeLocal() { KnowledgeLocal = 1; }
        public void UpdateKnowledgeNature() { KnowledgeNature = 1; }
        public void UpdateKnowledgeNobility() { KnowledgeNobility = 1; }
        public void UpdateKnowledgePlanes() { KnowledgePlanes = 1; }
        public void UpdateKnowledgeReligion() { KnowledgeReligion = 1; }
        public void UpdateLinguistics() { Linguistics = 1; }
        public void UpdatePerception() { Perception = 1; }
        public void UpdatePerform() { Perform = 1; }
        public void UpdateProfession() { Profession = 1; }
        public void UpdateRide() { Ride = 1; }
        public void UpdateSenseMotive() { SenseMotive = 1; }
        public void UpdateSleightOfHand() { SleightOfHand = 1; }
        public void UpdateSpellcraft() { Spellcraft = 1; }
        public void UpdateStealth() { Stealth = 1; }
        public void UpdateSurvival() { Survival = 1; }
        public void UpdateSwim() { Swim = 1; }
        public void UpdateUseMagicDevice() { UseMagicDevice = 1; }



        // ------- needed for INavigationAware -------
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            FillFeats();
            FillSpells();
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }        
    }

    
}
