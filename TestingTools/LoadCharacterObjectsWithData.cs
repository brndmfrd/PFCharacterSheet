using CharacterDataObjects;
using CharacterDataObjects.CharacterDataConstants;
using CharacterDataObjects.CharacterDataElements;

namespace TestingTools
{
    public class LoadCharacterObjectsWithData
    {
        public static bool IhaveBeenBuilt = false;

        public LoadCharacterObjectsWithData()
        {
            IhaveBeenBuilt = true;
        }

        public void BuildUpNewCharacter()
        {
            MyCharacter.BasicCharacterInfo[Constants.CharacterName] = "Duraxis";
            MyCharacter.BasicCharacterInfo[Constants.PlayerName] = "Bryan";
            MyCharacter.BasicCharacterInfo[Constants.Alignment] = "True Neutral";
            MyCharacter.BasicCharacterInfo[Constants.Size] = Constants.Medium;
            MyCharacter.BasicCharacterInfo[Constants.Age] = "32";
            MyCharacter.BasicCharacterInfo[Constants.Race] = "Human";
            MyCharacter.BasicCharacterInfo[Constants.Deity] = "Pelor";
            MyCharacter.BasicCharacterInfo[Constants.Gender] = "Male";
            MyCharacter.BasicCharacterInfo[Constants.Height] = "6'4''";
            MyCharacter.BasicCharacterInfo[Constants.Weight] = "260 lbs";
            MyCharacter.BasicCharacterInfo[Constants.Eyes] = "Brown";
            MyCharacter.BasicCharacterInfo[Constants.Hair] = "Brown";
            MyCharacter.BasicCharacterInfo[Constants.Homeland] = "Muskegon";

            MyCharacter.Languages.Add("Common");
            MyCharacter.Languages.Add("Dwarven");
            MyCharacter.Languages.Add("Elvish");


            MyCharacter.AbilityScores[Constants.Strength] = new Ability
            {
                Name = Constants.Strength,
                Value = 17,
                TempAdjustment = 0,
                TempModifier = 0
            };
            MyCharacter.AbilityScores[Constants.Dexterity] = new Ability
            {
                Name = Constants.Dexterity,
                Value = 13,
                TempAdjustment = 0,
                TempModifier = 0
            };
            MyCharacter.AbilityScores[Constants.Constitution] = new Ability
            {
                Name = Constants.Constitution,
                Value = 16,
                TempAdjustment = 0,
                TempModifier = 0
            };
            MyCharacter.AbilityScores[Constants.Intelligence] = new Ability
            {
                Name = Constants.Intelligence,
                Value = 11,
                TempAdjustment = 0,
                TempModifier = 0
            };
            MyCharacter.AbilityScores[Constants.Wisdom] = new Ability
            {
                Name = Constants.Wisdom,
                Value = 16,
                TempAdjustment = 0,
                TempModifier = 0
            };
            MyCharacter.AbilityScores[Constants.Charisma] = new Ability
            {
                Name = Constants.Charisma,
                Value = 13,
                TempAdjustment = 0,
                TempModifier = 0
            };


            MyCharacter.Race.Name = "Dwarven";
            MyCharacter.Size.Size = Constants.Medium;
            MyCharacter.AC = new ArmorClass { Total = 25 };
            MyCharacter.HP = new HitPoints { Total = 17 };
            MyCharacter.Speed = new Movement { BaseSpeed = 5 };
            
            MyCharacter.JobClasses.Add(
                "Demo Knight", new JobClass
                {
                    Level = 12
                }
            );

            MyCharacter.Weapons.Add(new Weapon(Constants.Strength, Constants.Strength) { WeaponName = "Bastard Sword" } );

            MyCharacter.Armor.Add(new ArmorClassItems { ItemName = "Studded Leather", ArmorBonus = 4 });

            MyCharacter.Skills.Add(new Skill(Constants.Dexterity) { Name = "Acrobatics" , Ranks = 2 } );
            MyCharacter.Skills.Add(new Skill(Constants.Intelligence) { Name = "Craft", Ranks = 4 });
            MyCharacter.Skills.Add(new Skill(Constants.Strength) { Name = "Swim", Ranks = 2 });
            MyCharacter.Skills.Add(new Skill(Constants.Wisdom) { Name = "Handle Animal", Ranks = 2 });

            MyCharacter.Feats.Add(new Feat { Name = "Dodge" });
            MyCharacter.Feats.Add(new Feat { Name = "Mobility" });
            MyCharacter.Feats.Add(new Feat { Name = "Power Attack" });
            MyCharacter.Feats.Add(new Feat { Name = "Weapon Focus" });

            MyCharacter.Gear.Add(new Item { Name = "Flint and Steel" });
            MyCharacter.Gear.Add(new Item { Name = "Torch" });
            MyCharacter.Gear.Add(new Item { Name = "Bed roll" });
            MyCharacter.Gear.Add(new Item { Name = "Backpack" });

            MyCharacter.Money[Enums.Coins.CP] = 50;
            MyCharacter.Money[Enums.Coins.SP] = 34;
            MyCharacter.Money[Enums.Coins.GP] = 15;
            MyCharacter.Money[Enums.Coins.PP] = 1;

            MyCharacter.Spells.Add(new Spell { SpellName = "Prestidigitation" });
            MyCharacter.Spells.Add(new Spell { SpellName = "Create Water" });
            MyCharacter.Spells.Add(new Spell { SpellName = "Vampiric Touch" });
            MyCharacter.Spells.Add(new Spell { SpellName = "Detect Magic" });

            MyCharacter.SpellsPerDay[0] = 4;
            MyCharacter.SpellsPerDay[1] = 3;
            MyCharacter.SpellsPerDay[2] = 2;
            MyCharacter.SpellsPerDay[3] = 1;

            MyCharacter.SpellsKnown[0] = 4;
            MyCharacter.SpellsKnown[1] = 3;
            MyCharacter.SpellsKnown[2] = 2;
            MyCharacter.SpellsKnown[3] = 1;




        }


    }
}
