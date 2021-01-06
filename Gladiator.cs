using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordsAndSandals3Editor {
    public class Gladiator {

        #region Save Structure
        /// <summary>
        /// The Gladiator ID. 0-9, only used to sort characters.
        /// </summary>
        public string GladiatorID; // 0
        /// <summary>
        /// Unknown use. Always 123.
        /// </summary>
        public string UserID; // 1
        /// <summary>
        /// The character's name, with a limit of 30.
        /// </summary>
        public string Name; // 2
        /// <summary>
        /// The character's level.
        /// </summary>
        public string Level; // 3
        /// <summary>
        /// The amount of wins the character has.
        /// </summary>
        public string Wins; // 4
        /// <summary>
        /// The amount of losses the character has.
        /// </summary>
        public string Losses; // 5
        /// <summary>
        /// The quote the character says when starting a match, with a limit of 80.
        /// </summary>
        public string TauntQuote; // 6
        /// <summary>
        /// The quote the character says when they win a match, with a limit of 80.
        /// </summary>
        public string VictoryQuote; // 7

        #region Warfare Tree
        /// <summary>
        /// The data for the Warfare tree.
        /// </summary>
        private string WarfareTree; // 8
        public string WarfareSwordMastery;
        public string WarfareMaceMastery;
        public string WarfareAxeMastery;
        public string WarfarePolearmMastery;
        public string WarfareRangedMastery;
        public string WarfareTwoHandedMastery;
        public string WarfareDualWielding;
        public string WarfareGunMastery;
        public string WarfareCriticalMastery;
        public string WarfareWhirlwind;
        #endregion
        #region Arcane Tree
        /// <summary>
        /// The data for the Arcane tree.
        /// </summary>
        private string ArcaneTree; // 9
        public string ArcaneMagickaRegeneration;
        public string ArcaneArcaneLore;
        public string ArcaneFireMastery;
        public string ArcaneLightningMastery;
        public string ArcaneFrostMastery;
        public string ArcaneAbjurationMastery;
        public string ArcaneIllusionMastery;
        public string ArcanePoisonMastery;
        public string ArcaneNecromancyMastery;
        public string ArcaneEssence;
        #endregion
        #region Theatrics Tree
        /// <summary>
        /// The data for the Theatrics tree.
        /// </summary>
        private string TheatricsTree; // 10
        public string TheatricsMercantile;
        public string TheatricsForkedTongue;
        public string TheatricsGuitarMastery;
        public string TheatricsArchaeology;
        public string TheatricsDistortion;
        public string TheatricsAmplify;
        public string TheatricsSerenity;
        public string TheatricsShred;
        public string TheatricsVirtuoso;
        public string TheatricsPeoplesChampion;
        #endregion
        #region Survival Tree
        /// <summary>
        /// The data for the Survival tree.
        /// </summary>
        private string SurvivalTree; // 11
        public string SurvivalAcrobatics;
        public string SurvivalDodgeMastery;
        public string SurvivalConviction;
        public string SurvivalParryingMastery;
        public string SurvivalElementalResistance;
        public string SurvivalShieldMastery;
        public string SurvivalImmovable;
        public string SurvivalRobustConstitution;
        public string SurvivalArmourer;
        public string SurvivalJuggernaut;
        #endregion
        #region DNA Tree
        /// <summary>
        /// The data for the character's appearance.
        /// </summary>
        private string DNATree; // 12
        public string DNASkinColor;
        public string DNAHairColor;
        public string DNAHairType;
        public string DNABeardType;
        public string DNAHeight;
        public string DNAWeight;
        public string DNAEarsType;
        public string DNAEars2Type;
        public string DNAEyesType;
        public string DNAMouthType;
        public string DNABodyType;
        public string DNAUnknown;
        public string DNAAlignment;
        #endregion
        #region Attribs Tree
        /// <summary>
        /// The data for the base stats.
        /// </summary>
        private string AttribsTree; // 13
        public string AttribStrength;
        public string AttribVitality;
        public string AttribCharisma;
        public string AttribIntellect;
        public string AttribAgility;
        #endregion
        #region Talents Tree
        /// <summary>
        /// The data for the stat points investments. Recommended not to change.
        /// </summary>
        private string TalentsTree; // 14
        //private string TalentsWarfare;
        //private string TalentsArcane;
        //private string TalentsTheatrics;
        //private string TalentsSurvival;
        #endregion
        #region Stats Tree
        /// <summary>
        /// The data for stats.
        /// </summary>
        private string StatsTree; // 15
        public string Stats1;
        public string Stats2;
        public string Stats3Exp;
        public string Stats4TotalExpRequired;
        public string Stats5Gold;
        public string Stats6Wins;
        public string Stats7Losses;
        public string Stats8WinStreak;
        public string Stats9;
        #endregion

        /// <summary>
        /// Unknown use. Always 'A'.
        /// </summary>
        public string Achievements; // 16
        /// <summary>
        /// The amount of Gold the character has.
        /// </summary>
        public string Gold; // 17
        /// <summary>
        /// The maximum amount of items the character can have. 12 equipped + 18 backpack, maximum 30. 32 can be used to overwrite Date and Foozle data slots for extra items.
        /// </summary>
        public string MaxItems; // 18
        /// <summary>
        /// The spells the character currently owns.
        /// </summary>
        public string SpellsTree; // 19
        /// <summary>
        /// The spells the character carries.
        /// </summary>
        public string HotkeysTree; // 20
        /// <summary>
        /// The currently equipped Helmet.
        /// </summary>
        public string Inventory1EquippedHelmet; // 21
        /// <summary>
        /// The currently equipped Chest.
        /// </summary>
        public string Inventory2EquippedChest; // 22
        /// <summary>
        /// The currently equipped Shoulders.
        /// </summary>
        public string Inventory3EquippedShoulders; // 23
        /// <summary>
        /// The currently equipped Arms.
        /// </summary>
        public string Inventory4EquippedArms; // 24
        /// <summary>
        /// Unused.
        /// </summary>
        public string Inventory5Unused; // 25
        /// <summary>
        /// The currently equipped Legs.
        /// </summary>
        public string Inventory6EquippedLegs; // 26
        /// <summary>
        /// The currently equipped Feet.
        /// </summary>
        public string Inventory7EquippedFeet; // 27
        /// <summary>
        /// Unused.
        /// </summary>
        public string Inventory8Unused; // 28
        /// <summary>
        /// The currently equipped Shield/Dual Wield Weapon
        /// </summary>
        public string Inventory9EquippedOffHand; // 29
        /// <summary>
        /// The currently equipped Primary Weapon.
        /// </summary>
        public string Inventory10EquippedPrimaryWeapon; // 30
        /// <summary>
        /// The currently eqiupped Cape.
        /// </summary>
        public string Inventory11EquippedCape; // 31
        /// <summary>
        /// Unused.
        /// </summary>
        public string Inventory12Unused; // 32
        /// <summary>
        /// Item in slot 1.
        /// </summary>
        public string Inventory13Backpack1; // 33
        /// <summary>
        /// Item in slot 2.
        /// </summary>
        public string Inventory14Backpack2; // 34
        /// <summary>
        /// Item in slot 3.
        /// </summary>
        public string Inventory15Backpack3; // 35
        /// <summary>
        /// Item in slot 4.
        /// </summary>
        public string Inventory16Backpack4; // 36
        /// <summary>
        /// Item in slot 5.
        /// </summary>
        public string Inventory17Backpack5; // 37
        /// <summary>
        /// Item in slot 6.
        /// </summary>
        public string Inventory18Backpack6; // 38
        /// <summary>
        /// Item in slot 7.
        /// </summary>
        public string Inventory19Backpack7; // 39
        /// <summary>
        /// Item in slot 8.
        /// </summary>
        public string Inventory20Backpack8; // 40
        /// <summary>
        /// Item in slot 9.
        /// </summary>
        public string Inventory21Backpack9; // 41
        /// <summary>
        /// Item in slot 10.
        /// </summary>
        public string Inventory22Backpack10; // 42
        /// <summary>
        /// Item in slot 11.
        /// </summary>
        public string Inventory23Backpack11; // 43
        /// <summary>
        /// Item in slot 12.
        /// </summary>
        public string Inventory24Backpack12; // 44
        /// <summary>
        /// Item in slot 13.
        /// </summary>
        public string Inventory25Backpack13; // 45
        /// <summary>
        /// Item in slot 14.
        /// </summary>
        public string Inventory26Backpack14; // 46
        /// <summary>
        /// Item in slot 15.
        /// </summary>
        public string Inventory27Backpack15; // 47
        /// <summary>
        /// Item in slot 16.
        /// </summary>
        public string Inventory28Backpack16; // 48
        /// <summary>
        /// Item in slot 17.
        /// </summary>
        public string Inventory29Backpack17; // 49
        /// <summary>
        /// Item in slot 18.
        /// </summary>
        public string Inventory30Backpack18; // 50
        /// <summary>
        /// The character's creation date. Can be used for the Item in slot 19 if 20 Backpack slots is applied.
        /// </summary>
        public string Date; // 51
        /// <summary>
        /// Unknown. Can be used for the item in slot 20 if 20 Backpack slots is applied.
        /// </summary>
        public string Foozle; // 52
        /// <summary>
        /// The Arena Champion stage.
        /// </summary>
        public string NextBoss; // 53

        public string LoadedInventoryType;
        public string LoadedInventoryEnchantment1;
        public string LoadedInventoryItem;
        public string LoadedInventoryEnchantment2;
        public string LoadedInventoryAlignment;

        public string LoadedGladiator;
        #endregion

        private bool CanSave = false;
        public string[] AllArraysNames;
        public string[] AllArraysIDs;

        public bool LoadGladiator(string Data) {
            string[] DataArray = Data.Split(',');
            string[] InnerDataArray;
            if (DataArray.Length == 54) {
                LoadedGladiator = Data;
                GladiatorID = DataArray[0];
                UserID = DataArray[1];
                Name = DataArray[2];
                Level = DataArray[3];
                Wins = DataArray[4];
                Losses = DataArray[5];
                TauntQuote = DataArray[6];
                VictoryQuote = DataArray[7];

                WarfareTree = DataArray[8];
                InnerDataArray = WarfareTree.Split('_');
                WarfareSwordMastery = InnerDataArray[0];
                WarfareMaceMastery = InnerDataArray[1];
                WarfareAxeMastery = InnerDataArray[2];
                WarfarePolearmMastery = InnerDataArray[3];
                WarfareRangedMastery = InnerDataArray[4];
                WarfareTwoHandedMastery = InnerDataArray[5];
                WarfareDualWielding = InnerDataArray[6];
                WarfareGunMastery = InnerDataArray[7];
                WarfareCriticalMastery = InnerDataArray[8];
                WarfareWhirlwind = InnerDataArray[9];
                InnerDataArray = null;

                ArcaneTree = DataArray[9];
                InnerDataArray = ArcaneTree.Split('_');
                ArcaneMagickaRegeneration = InnerDataArray[0];
                ArcaneArcaneLore = InnerDataArray[1];
                ArcaneFireMastery = InnerDataArray[2];
                ArcaneLightningMastery = InnerDataArray[3];
                ArcaneFrostMastery = InnerDataArray[4];
                ArcaneAbjurationMastery = InnerDataArray[5];
                ArcaneIllusionMastery = InnerDataArray[6];
                ArcanePoisonMastery = InnerDataArray[7];
                ArcaneNecromancyMastery = InnerDataArray[8];
                ArcaneEssence = InnerDataArray[9];
                InnerDataArray = null;

                TheatricsTree = DataArray[10];
                InnerDataArray = TheatricsTree.Split('_');
                TheatricsMercantile = InnerDataArray[0];
                TheatricsForkedTongue= InnerDataArray[1];
                TheatricsGuitarMastery = InnerDataArray[2];
                TheatricsArchaeology = InnerDataArray[3];
                TheatricsDistortion = InnerDataArray[4];
                TheatricsAmplify = InnerDataArray[5];
                TheatricsSerenity = InnerDataArray[6];
                TheatricsShred= InnerDataArray[7];
                TheatricsVirtuoso = InnerDataArray[8];
                TheatricsPeoplesChampion = InnerDataArray[9];
                InnerDataArray = null;

                SurvivalTree = DataArray[11];
                InnerDataArray = SurvivalTree.Split('_');
                SurvivalAcrobatics = InnerDataArray[0];
                SurvivalDodgeMastery = InnerDataArray[1];
                SurvivalConviction = InnerDataArray[2];
                SurvivalParryingMastery = InnerDataArray[3];
                SurvivalElementalResistance = InnerDataArray[4];
                SurvivalShieldMastery = InnerDataArray[5];
                SurvivalImmovable = InnerDataArray[6];
                SurvivalRobustConstitution = InnerDataArray[7];
                SurvivalArmourer = InnerDataArray[8];
                SurvivalJuggernaut = InnerDataArray[9];
                InnerDataArray = null;

                DNATree = DataArray[12];
                InnerDataArray = DNATree.Split('_');
                DNASkinColor = InnerDataArray[0];
                DNAHairColor = InnerDataArray[1];
                DNAHairType = InnerDataArray[2];
                DNABeardType = InnerDataArray[3];
                DNAHeight = InnerDataArray[4];
                DNAWeight = InnerDataArray[5];
                DNAEarsType = InnerDataArray[6];
                DNAEars2Type = InnerDataArray[7];
                DNAEyesType = InnerDataArray[8];
                DNAMouthType = InnerDataArray[9];
                DNABodyType = InnerDataArray[10];
                DNAUnknown = InnerDataArray[11];
                DNAAlignment = InnerDataArray[12];
                InnerDataArray = null;

                AttribsTree = DataArray[13];
                InnerDataArray = AttribsTree.Split('_');
                AttribStrength = InnerDataArray[0];
                AttribVitality = InnerDataArray[1];
                AttribCharisma = InnerDataArray[2];
                AttribIntellect = InnerDataArray[3];
                AttribAgility = InnerDataArray[4];
                InnerDataArray = null;

                TalentsTree = DataArray[14];

                StatsTree = DataArray[15];
                InnerDataArray = StatsTree.Split('_');
                Stats1 = InnerDataArray[0];
                Stats2 = InnerDataArray[1];
                Stats3Exp = InnerDataArray[2];
                Stats4TotalExpRequired = InnerDataArray[3];
                Stats5Gold = InnerDataArray[4];
                Stats6Wins = InnerDataArray[5];
                Stats7Losses = InnerDataArray[6];
                Stats8WinStreak = InnerDataArray[7];
                Stats9 = InnerDataArray[8];
                InnerDataArray = null;

                Achievements = DataArray[16];
                Gold = DataArray[17];
                MaxItems = DataArray[18];
                SpellsTree = DataArray[19];
                HotkeysTree = DataArray[20];

                Inventory1EquippedHelmet = DataArray[21];
                Inventory2EquippedChest = DataArray[22];
                Inventory3EquippedShoulders = DataArray[23];
                Inventory4EquippedArms = DataArray[24];
                Inventory5Unused = DataArray[25];
                Inventory6EquippedLegs = DataArray[26];
                Inventory7EquippedFeet = DataArray[27];
                Inventory8Unused = DataArray[28];
                Inventory9EquippedOffHand = DataArray[29];
                Inventory10EquippedPrimaryWeapon = DataArray[30];
                Inventory11EquippedCape = DataArray[31];
                Inventory12Unused = DataArray[32];
                Inventory13Backpack1 = DataArray[33];
                Inventory14Backpack2 = DataArray[34];
                Inventory15Backpack3 = DataArray[35];
                Inventory16Backpack4 = DataArray[36];
                Inventory17Backpack5 = DataArray[37];
                Inventory18Backpack6 = DataArray[38];
                Inventory19Backpack7 = DataArray[39];
                Inventory20Backpack8 = DataArray[40];
                Inventory21Backpack9 = DataArray[41];
                Inventory22Backpack10 = DataArray[42];
                Inventory23Backpack11 = DataArray[43];
                Inventory24Backpack12 = DataArray[44];
                Inventory25Backpack13 = DataArray[45];
                Inventory26Backpack14 = DataArray[46];
                Inventory27Backpack15 = DataArray[47];
                Inventory28Backpack16 = DataArray[48];
                Inventory29Backpack17 = DataArray[49];
                Inventory30Backpack18 = DataArray[50];
                Date = DataArray[51];
                Foozle = DataArray[52];
                NextBoss = DataArray[53];
                CanSave = true;

                return true;
            }

            return false;
        }
        public bool SetGladiatorAsChampion(int ChampionID, bool AllowCommas = false) {
            string Data = null;

            switch (ChampionID) {
                case 0:
                    Data = ArenaChampions.TheFearfulPrisoner;
                    break;
                case 1:
                    Data = ArenaChampions.BoarhideTraderPigsus;
                    break;
                case 2:
                    Data = ArenaChampions.XanfarTheHaunted;
                    break;
                case 3:
                    Data = ArenaChampions.Obliterator9000;
                    break;
                case 4:
                    Data = ArenaChampions.MrOmazing;
                    break;
                case 5:
                    Data = ArenaChampions.TheYetiProject;
                    break;
                case 6:
                    Data = ArenaChampions.BattlemaidenAnna;
                    break;
                case 7:
                    Data = ArenaChampions.Fizzacles;
                    break;
                case 8:
                    Data = ArenaChampions.SirBrianOfMay;
                    break;
                case 9:
                    Data = ArenaChampions.Arglaxx;
                    break;
                case 10:
                    Data = ArenaChampions.TheBoneslinger;
                    break;
                case 11:
                    Data = ArenaChampions.ArchfiendCoalbhaal;
                    break;
                case 12:
                    Data = ArenaChampions.Bladetronv20;
                    break;
                case 13:
                    Data = ArenaChampions.MossoclesTheVenimous;
                    break;
                case 14:
                    Data = ArenaChampions.GreatKnightGallantrus;
                    break;
                case 15:
                    Data = ArenaChampions.Bargle;
                    break;
                case 16:
                    Data = ArenaChampions.Platos;
                    break;
                case 17:
                    Data = ArenaChampions.EvilNinjaRedux;
                    break;
                case 18:
                    Data = ArenaChampions.MagnificentLeopold;
                    break;
                case 19:
                    Data = ArenaChampions.FatherPainbringer;
                    break;
                case 20:
                    Data = ArenaChampions.BluescreenDeath;
                    break;
                case 21:
                    Data = ArenaChampions.TheUndeadGreatBeast;
                    break;
                case 22:
                    Data = ArenaChampions.FallenEmperorAntares;
                    break;
                case 23:
                    Data = ArenaChampions.UltratusOmega;
                    break;
            }

            string[] DataArray = Data.Split(',');
            string[] InnerDataArray;
            if (DataArray.Length == 54 && Data != null) {
                Name = DataArray[2];
                Level = DataArray[3];
                TauntQuote = DataArray[6];
                VictoryQuote = DataArray[7];

                if (AllowCommas) {
                    TauntQuote = TauntQuote.Replace(";", ",");
                    VictoryQuote = VictoryQuote.Replace(";", ",");
                }

                DNATree = DataArray[12];
                InnerDataArray = DNATree.Split('_');
                DNASkinColor = InnerDataArray[0];
                DNAHairColor = InnerDataArray[1];
                DNAHairType = InnerDataArray[2];
                DNABeardType = InnerDataArray[3];
                DNAHeight = InnerDataArray[4];
                DNAWeight = InnerDataArray[5];
                DNAEarsType = InnerDataArray[6];
                DNAEars2Type = InnerDataArray[7];
                DNAEyesType = InnerDataArray[8];
                DNAMouthType = InnerDataArray[9];
                DNABodyType = InnerDataArray[10];
                DNAUnknown = InnerDataArray[11];
                DNAAlignment = InnerDataArray[12];
                InnerDataArray = null;

                Inventory1EquippedHelmet = DataArray[21];
                Inventory2EquippedChest = DataArray[22];
                Inventory3EquippedShoulders = DataArray[23];
                Inventory4EquippedArms = DataArray[24];
                Inventory6EquippedLegs = DataArray[26];
                Inventory7EquippedFeet = DataArray[27];
                Inventory9EquippedOffHand = DataArray[29];
                Inventory10EquippedPrimaryWeapon = DataArray[30];
                Inventory11EquippedCape = DataArray[31];

                return true;
            }

            return false;
        }
        public string GenerateInventoryItem() {
            if (LoadedInventoryType == null && LoadedInventoryEnchantment1 == null && LoadedInventoryItem == null && LoadedInventoryEnchantment2 == null && LoadedInventoryAlignment == null) {
                return "0";
            }
            return LoadedInventoryType + "_" + LoadedInventoryEnchantment1 + "_" + LoadedInventoryItem + "_" + LoadedInventoryEnchantment2 + "_" + LoadedInventoryAlignment;
        }
        public string GenerateData() {
            if (CanSave) {
                WarfareTree = WarfareSwordMastery + "_" + WarfareMaceMastery + "_" + WarfareAxeMastery + "_" + WarfarePolearmMastery + "_" + WarfareRangedMastery + "_" + WarfareTwoHandedMastery + "_" + WarfareDualWielding + "_" + WarfareGunMastery + "_" + WarfareCriticalMastery + "_" + WarfareWhirlwind;

                ArcaneTree = ArcaneMagickaRegeneration + "_" + ArcaneArcaneLore + "_" + ArcaneFireMastery + "_" + ArcaneLightningMastery + "_" + ArcaneFrostMastery + "_" + ArcaneAbjurationMastery + "_" + ArcaneIllusionMastery + "_" + ArcanePoisonMastery + "_" + ArcaneNecromancyMastery + "_" + ArcaneEssence;

                TheatricsTree =TheatricsMercantile + "_" + TheatricsForkedTongue + "_" + TheatricsGuitarMastery + "_" + TheatricsArchaeology + "_" + TheatricsDistortion + "_" + TheatricsAmplify + "_" + TheatricsSerenity + "_" + TheatricsShred + "_" + TheatricsVirtuoso + "_" + TheatricsPeoplesChampion;

                SurvivalTree = SurvivalAcrobatics + "_" + SurvivalDodgeMastery + "_" + SurvivalConviction + "_" + SurvivalParryingMastery + "_" + SurvivalElementalResistance + "_" + SurvivalShieldMastery + "_" + SurvivalImmovable + "_" + SurvivalRobustConstitution + "_" + SurvivalArmourer + "_" + SurvivalJuggernaut;

                DNATree = DNASkinColor + "_" + DNAHairColor + "_" + DNAHairType + "_" + DNABeardType + "_" + DNAHeight + "_" + DNAWeight + "_" + DNAEarsType + "_" + DNAEars2Type + "_" + DNAEyesType + "_" + DNAMouthType + "_" + DNABodyType + "_" + DNAUnknown + "_" + DNAAlignment;

                AttribsTree = AttribStrength + "_" + AttribVitality + "_" + AttribCharisma + "_" + AttribIntellect + "_" + AttribAgility;

                StatsTree = Stats1 + "_" + Stats2 + "_" + Stats3Exp + "_" + Stats4TotalExpRequired + "_" + Stats5Gold + "_" + Stats6Wins + "_" + Stats7Losses + "_" + Stats8WinStreak + "_" + Stats9;

                return GladiatorID + "," + UserID + "," + Name.Trim(' ') + "," + Level + "," + Wins + "," + Losses + "," + TauntQuote.Trim(' ') + "," + VictoryQuote.Trim(' ') + "," + WarfareTree + "," + ArcaneTree + "," + TheatricsTree + "," + SurvivalTree + "," + DNATree + "," + AttribsTree + "," + TalentsTree + "," + StatsTree + "," + Achievements + "," + Gold + "," + MaxItems + "," + SpellsTree + "," + HotkeysTree + "," + Inventory1EquippedHelmet + "," + Inventory2EquippedChest + "," + Inventory3EquippedShoulders + "," + Inventory4EquippedArms + "," + Inventory5Unused + "," + Inventory6EquippedLegs + "," + Inventory7EquippedFeet + "," + Inventory8Unused + "," + Inventory9EquippedOffHand + "," + Inventory10EquippedPrimaryWeapon + "," + Inventory11EquippedCape + "," + Inventory12Unused + "," + Inventory13Backpack1 + "," + Inventory14Backpack2 + "," + Inventory15Backpack3 + "," + Inventory16Backpack4 + "," + Inventory17Backpack5 + "," + Inventory18Backpack6 + "," + Inventory19Backpack7 + "," + Inventory20Backpack8 + "," + Inventory21Backpack9 + "," + Inventory22Backpack10 + "," + Inventory23Backpack11 + "," + Inventory24Backpack12 + "," + Inventory25Backpack13 + "," + Inventory26Backpack14 + "," + Inventory27Backpack15 + "," + Inventory28Backpack16 + "," + Inventory29Backpack17 + "," + Inventory30Backpack18 + "," + Date + "," + Foozle + "," + NextBoss;
            }

            return null;
        }
    }

    public class Items {
        public static readonly string[] ItemTypeIDs = { "1_1", "2_2", "3_3", "4_4", "6_6", "7_7", "9_10", "10_12", "11_11" };
        public static readonly string[] ItemTypeNames = { "Helmet", "Chest Armor", "Shoulder Armor", "Gauntlets", "Leg Armor", "Boots", "Shield", "Weapon", "Cape" };
        #region Weapons
        public static readonly string[] WeaponNames = { "Dagger",
                                                        "Dirk",
                                                        "Gladius",
                                                        "Shamshir",
                                                        "Spatha",
                                                        "Machete",
                                                        "Knife",
                                                        "Hooksword",
                                                        "Sabre",
                                                        "Shortsword",
                                                        "Rapier",
                                                        "Scimitar",
                                                        "Cutlass",
                                                        "Falchion",
                                                        "Broadsword",
                                                        "Longsword",
                                                        "Katana",
                                                        "Wakizashi",
                                                        "Two Hand Sword",
                                                        "Claymore",
                                                        "Greatsword",
                                                        "Daikatana",
                                                        "Bastard Sword",
                                                        "Cleaver",
                                                        "Hatchet",
                                                        "Hand Axe",
                                                        "Battle Axe",
                                                        "Sagaris",
                                                        "War Axe",
                                                        "Lochaber",
                                                        "Bardiche",
                                                        "Pickaxe",
                                                        "Heavy Axe",
                                                        "Greataxe",
                                                        "Staff",
                                                        "Sickle",
                                                        "Scythe",
                                                        "Spear",
                                                        "Halberd",
                                                        "Pike",
                                                        "Glaive",
                                                        "Poleaxe",
                                                        "Trident",
                                                        "Blackjack",
                                                        "Hammer",
                                                        "Club",
                                                        "Mace",
                                                        "Morning Star",
                                                        "Sceptre",
                                                        "Warhammer",
                                                        "Flail",
                                                        "Maul",
                                                        "Spiked Club",
                                                        "Studded Club",
                                                        "Mallet",
                                                        "Cudgel",
                                                        "Flanged Mace",
                                                        "Dual Flail",
                                                        "Short Bow",
                                                        "Long Bow",
                                                        "Composite Bow",
                                                        "Crossbow",
                                                        "Compound Bow",
                                                        "Ballista",
                                                        "Phaser",
                                                        "Bolter Gun",
                                                        "Laser Gun",
                                                        "Blunderbuss",
                                                        "Musket",
                                                        "Shotgun",
                                                        "Double Barrel Shotgun",
                                                        "Heavy Bolter Gun",
                                                        "Assault Rifle",
                                                        "Uzi",
                                                        "Machine Gun",
                                                        "Chain Gun",
                                                        "Autocannon",
                                                        "Flame Cannon",
                                                        "Rocket Launcher",
                                                        "Mandolin",
                                                        "Lute",
                                                        "Acoustic Guitar",
                                                        "Flamenco Guitar",
                                                        "Twin Acoustic Guitar",
                                                        "Teleblaster",
                                                        "Stratoblaster",
                                                        "Scourge",
                                                        "Soaring V",
                                                        "Keytar",
                                                        "Twin Devastator",
                                                        "Boxing Gloves (Unused)",
                                                        "Nunchaka (Evil Ninja Redux)",
                                                        "Steel Claws (Xanfar the Haunted)",
                                                        "Laser Sabre (Bladetron 2.0)",
                                                        "Pig Rake (Boarhide Trader Pigsus)",
                                                        "Feargalstaff (The Fearful Prisoner)",
                                                        "Yeti Club (The Yeti Project)",
                                                        "Blobulous Staff (Fizzacles)",
                                                        "Red Special (Sir Brian of May)",
                                                        "Arglaxx's Paw (Arglaxx)",
                                                        "Mossocles' Earthshaker (Mossocles the Venomous)",
                                                        "* Orb (Bargle)",
                                                        "Voltblade (Bluescreen Death)",
                                                        "Worldsmasher (The Undead Great Beast)",
                                                        "Empire Blade (Fallen Emperor Antares)",
                                                        "* UltraChainsaw (Ultratus Omega)"
                                                    }; // * = Requires HUMAN or AUTOMATON as body type
        public static readonly string[] WeaponIDs = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                                                    "11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
                                                    "21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
                                                    "31", "32", "33", "34", "35", "36", "37", "38", "39", "40",
                                                    "41", "42", "43", "44", "45", "46", "47", "48", "49", "50",
                                                    "51", "52", "53", "54", "55", "56", "57", "58", "59", "60",
                                                    "61", "62", "63", "64", "65", "66", "67", "68", "69", "70",
                                                    "71", "72", "73", "74", "75", "76", "77", "78", "79", "80",
                                                    "81", "82", "83", "84", "85", "86", "87", "88", "89", "90",
                                                    "91", "92", "93", "94", "95", "96", "97", "98", "99", "100",
                                                    "101", "102", "103", "104", "105", "106"
                                                  };
        #endregion
        #region Armors
        public static readonly string[] ArmorNames = { "Cloth",
                                                       "Silk",
                                                       "Boarhide",
                                                       "Leather",
                                                       "Myrmidon",
                                                       "Legion",
                                                       "Chainmail",
                                                       "Platemail",
                                                       "Spiked",
                                                       "Knight",
                                                       "Imperium"
                                                     };
        public static readonly string[] ArmorIDs = { "1","2","3","4","5","6","7","8","9","10","11" };
        #endregion
        #region Helmets
        public static readonly string[] HelmetNames = { "Bandana",
                                                        "Cowl",
                                                        "Wizard Hat",
                                                        "Beret",
                                                        "Leather Cap",
                                                        "Barbarian Helm",
                                                        "Samurai Helmet",
                                                        "Viking Helmet",
                                                        "Iron Cap",
                                                        "Legion Helm", 
                                                        "Braxis Helm",
                                                        "Thracian Helmet",
                                                        "Ninja Mask", "Nemes",
                                                        "Iron Mask",
                                                        "Corinthian Helm",
                                                        "Myrmidon Helmet",
                                                        "Nomad Scard",
                                                        "Sombrero",
                                                        "Coppergate Helm", 
                                                        "Bamboo Hat",
                                                        "Tribal Headpiece",
                                                        "Pirate Hat",
                                                        "Knight Helm",
                                                        "Great Helm",
                                                        "Retarius Helmet",
                                                        "Cyborg Jaw",
                                                        "Galactic Helm",
                                                        "Drakondier Helm",
                                                        "Minotaur Helm",
                                                        "Crown",
                                                        "Alien Battle Helmet" 
                                                      };
        public static readonly string[] HelmetIDs = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", 
                                                      "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", 
                                                      "21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
                                                      "31", "32" 
                                                    };
        #endregion
        #region Capes
        public static readonly string[] CapeNames = { "Cloth Shawl",
                                                      "Silk Cloak",
                                                      "Ermine Cloak",
                                                      "Vampire Cloak",
                                                      "Angel Wings",
                                                      "Demon Wings",
                                                      "Tail Carapace"
                                                    };
        public static readonly string[] CapeIDs = { "1", "2", "3", "4", "5", "6", "7"};
        #endregion
        #region Shields
        public static readonly string[] ShieldNames = { "Buckler",
                                                        "Targe Shield",
                                                        "Wooden Shield",
                                                        "Spiked Shield",
                                                        "Heater Shield",
                                                        "Triangle Shield",
                                                        "Crusade Shield",
                                                        "Tower Shield",
                                                        "Tapered Shield" };
        public static readonly string[] ShieldIDs = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        #endregion
        #region Enchantments
        public static readonly string[] ItemPrimaryEnchantmentNames = {
            "N/A, (Common) Lv. 0",
            "Burly, +1 strength (Enchanted) Lv. 3",
            "Stout, +2 strength (Enchanted) Lv. 5",
            "Thug's, +3 strength (Enchanted) Lv. 6",
            "Brute's, +4 strength (Enchanted) Lv. 7",
            "Strong, +5 strength (Enchanted) Lv. 9",
            "Beastly, +6 strength (Enchanted) Lv. 10",
            "Powerful, +7 strength (Enchanted) Lv. 12",
            "Towering, +8 strength (Rare enchanted) Lv. 13",
            "Mighty, +9 strength (Rare enchanted) Lv. 15",
            "Titan, +10 strength (Rare enchanted) Lv. 16",
            "Rugged, +1 vitality (Enchanted) Lv. 3",
            "Fortified, +2 vitality (Enchanted) Lv. 5",
            "Hardy, +3 vitality (Enchanted) Lv. 6",
            "Tough, +4 vitality (Enchanted) Lv. 7",
            "Watchman's, +5 vitality (Enchanted) Lv. 9",
            "Resilient, +6 vitality (Enchanted) Lv. 10",
            "Robust, +7 vitality (Enchanted) Lv. 12",
            "Sentinel's, +8 vitality (Rare enchanted) Lv. 13",
            "Enduring, +9 vitality (Rare enchanted) Lv. 15",
            "Everlasting, +10 vitality (Rare enchanted) Lv. 16",
            "Charmed, +1 charisma (Enchanted) Lv. 3",
            "Alluring, +2 charisma (Enchanted) Lv. 5",
            "Shark's, +3 charisma (Enchanted) Lv. 6",
            "Charlatan, +4 charisma (Enchanted) Lv. 7",
            "Etched, +5 charisma (Enchanted) Lv. 9",
            "Actor's, +6 charisma (Enchanted) Lv. 10",
            "Bright, +7 charisma (Enchanted) Lv. 12",
            "Hypnotic, +8 charisma (Rare enchanted) Lv. 13",
            "Dazzling, +9 charisma (Rare enchanted) Lv. 15",
            "Iconic, +10 charisma (Rare enchanted) Lv. 16",
            "Clever, +1 intellect (Enchanted) Lv. 3",
            "Apprentice's, +2 intellect (Enchanted) Lv. 5",
            "Quizzical, +3 intellect (Enchanted) Lv. 6",
            "Impetus, +4 intellect (Enchanted) Lv. 7",
            "Studious, +5 intellect (Enchanted) Lv. 9",
            "Scholarly, +6 intellect (Enchanted) Lv. 10",
            "Lapis, +7 charisma (Enchanted) Lv. 12",
            "Arcane, +8 intellect (Rare enchanted) Lv. 13",
            "Radiant, +9 intellect (Rare enchanted) Lv. 15",
            "Omniscient, +10 intellect (Rare enchanted) Lv. 16",
            "Fast, +1 intellect (Enchanted) Lv. 3",
            "Swift, +2 intellect (Enchanted) Lv. 5",
            "Thief's, +3 intellect (Enchanted) Lv. 6",
            "Rapid, +4 intellect (Enchanted) Lv. 7",
            "Fleet, +5 intellect (Enchanted) Lv. 9",
            "Dextrous, +6 intellect (Enchanted) Lv. 10",
            "Elusive, +7 charisma (Enchanted) Lv. 12",
            "Deceptive, +8 intellect (Rare enchanted) Lv. 13",
            "Mercurial, +9 intellect (Rare enchanted) Lv. 15",
            "Vorpal, +10 intellect (Rare enchanted) Lv. 16",
            "Inigo's, +1 sword mastery +2 agility (Enchanted) Lv. 9",
            "Westley's, +2 sword mastery +4 agility (Enchanted) Lv. 12",
            "Bonecrusher's, +1 mace mastery +2 strength (Enchanted) Lv. 9",
            "Shattering, +2 mace mastery +4 strength (Enchanted) Lv. 12",
            "Biting, +1 axe mastery +2 vitality (Enchanted) Lv. 9",
            "Forester's, +2 axe mastery +4 vitality (Enchanted) Lv. 12",
            "Warden, +1 polearm mastery +2 strength (Enchanted) Lv. 9",
            "Tower, +2 polearm mastery +4 strength (Enchanted) Lv. 12",
            "Fearful, +1 ranged weapon mastery +2 agility (Enchanted) Lv. 9",
            "Craven's, +2 ranged weapon mastery +4 agility (Enchanted) Lv. 12",
            "Barbarian, +1 two handed weapon mastery +2 strength (Enchanted) Lv. 9",
            "Cavalier's, +2 two handed weapon mastery +4 strength (Enchanted) Lv. 12",
            "Ambidextrous, +1 dual wielding +2 agility (Enchanted) Lv. 9",
            "Samurai, +2 dual wielding +4 agility (Enchanted) Lv. 12",
            "Marine's, +1 gun mastery +2 agility (Enchanted) Lv. 9",
            "Commando's, +2 gun mastery +4 agility (Enchanted) Lv. 12",
            "Destructive, +1 critical mastery +2 vitality (Enchanted) Lv. 9",
            "Ruinous, +2 critical mastery +4 vitality (Enchanted) Lv. 12",
            "Tempestuous, +1 whirlwind +2 agility (Enchanted) Lv. 9",
            "Cyclonic, +2 whirlwind +4 agility (Enchanted) Lv. 12",
            "Mystical, +1 magicka regeneration +2 agility (Enchanted) Lv. 9",
            "Conjurer's, +2 magicka regeneration +4 agility (Enchanted) Lv. 12",
            "Night Blue, +1 arcane lore +2 agility (Enchanted) Lv. 9",
            "Sagan's, +2 arcane lore +4 agility (Enchanted) Lv. 12",
            "Flameweaver, +1 fire mastery +2 agility (Enchanted) Lv. 9",
            "Magma, +2 fire mastery +4 agility (Enchanted) Lv. 12",
            "Thundrous, +1 lightning mastery +2 agility (Enchanted) Lv. 9",
            "Electric, +2 lightning mastery +4 agility (Enchanted) Lv.  +12",
            "Chilling, +1 frost mastery +2 agility (Enchanted) Lv. 9",
            "Arctic, +2 frost mastery +4 agility (Enchanted) Lv. 12",
            "Cleric's, +1 abjuration mastery +2 intellect (Enchanted) Lv. 9",
            "Blessed, +2 abjuration mastery +4 intellect (Enchanted) Lv. 12",
            "Sorcerous, +1 illusion mastery +2 intellect (Enchanted) Lv. 9",
            "Illusionist's, +2 illusion mastery +4 intellect (Enchanted) Lv. 12",
            "Soulstone, +1 poison mastery +2 intellect (Enchanted) Lv. 9",
            "Shukamas, +2 poison mastery +4 intellect (Enchanted) Lv. 12",
            "Grieving, +1 necromancy mastery +2 agility (Enchanted) Lv. 9",
            "Haunted, +2 necromancy mastery +4 intellect (Enchanted) Lv. 12",
            "Wizard's, +1 essence +2 agility (Enchanted) Lv. 9",
            "Archmage's, +2 essence +4 agility (Enchanted) Lv. 12",
            "Influential, +1 mercantile +2 charisma (Enchanted) Lv. 9",
            "Branson's, +2 mercantile +4 charisma (Enchanted) Lv. 12",
            "Inflammatory, +1 forked tongue +2 charisma (Enchanted) Lv. 9",
            "Controversial, +2 forked tongue +4 charisma (Enchanted) Lv. 12",
            "Wailing, +1 guitar mastery +2 intellect (Enchanted) Lv. 9",
            "Santana's, +2 guitar mastery +4 intellect (Enchanted) Lv. 12",
            "Indy's, +1 archaeology +2 vitality (Enchanted) Lv. 9",
            "Egyptian, +2 archaeology +4 vitality (Enchanted) Lv. 12",
            "Cacophonous, +1 distortion +2 charisma (Enchanted) Lv. 9",
            "Hawkins, +2 distortion +4 charisma (Enchanted) Lv. 12",
            "Rumbling, +1 amplify +2 charisma (Enchanted) Lv. 9",
            "Sonic, +2 amplify +4 charisma (Enchanted) Lv. 12",
            "Lionel's, +1 serenity +2 charisma (Enchanted) Lv. 9",
            "Spiritual, +2 serenity +4 charisma (Enchanted) Lv. 12",
            "Shredmaster, +1 shred +2 intellect (Enchanted) Lv. 9",
            "May's, +2 shred +4 intellect (Enchanted) Lv. 12",
            "Protege's, +1 virtuoso +2 charisma (Enchanted) Lv. 9",
            "Amadeus, +2 virtuoso +4 charisma (Enchanted) Lv. 12",
            "Gilded, +1 people's champion +2 charisma (Enchanted) Lv. 9",
            "Silas', +2 people's champion +4 charisma (Enchanted) Lv. 12",
            "Flambouyant, +1 acrobatics +2 agility (Enchanted) Lv. 9",
            "Athlete's, +2 acrobatics +4 agility (Enchanted) Lv. 12",
            "Ocher, +1 dodge mastery +2 agility (Enchanted) Lv. 9",
            "Wrought, +2 dodge mastery +4 agility (Enchanted) Lv. 12",
            "Eldritch, +1 conviction +2 charisma (Enchanted) Lv. 9",
            "Yuri's, +2 conviction +4 charisma (Enchanted) Lv. 12",
            "Elemental, +1 parrying mastery +2 charisma (Enchanted) Lv. 9",
            "Primeval, +2 parrying mastery +4 charisma (Enchanted) Lv. 12",
            "Phalanx, +1 elemental resistance +2 charisma (Enchanted) Lv. 9",
            "Perseus', +2 elemental resistance +4 charisma (Enchanted) Lv. 12",
            "Grecian, +1 shield mastery +2 charisma (Enchanted) Lv. 9",
            "Fezzik's, +2 shield mastery +4 charisma (Enchanted) Lv. 12",
            "Stubborn, +1 immovable +2 charisma (Enchanted) Lv. 9",
            "Cardwell's, +2 immovable +4 charisma (Enchanted) Lv. 12",
            "Zirconium, +1 robust constitution +2 charisma (Enchanted) Lv. 9",
            "Diamond, +2 robust constitution +4 charisma (Enchanted) Lv. 12",
            "Forged, +1 armourer +2 charisma (Enchanted) Lv. 9",
            "Blacksmith's, +2 armourer +4 charisma (Enchanted) Lv. 12",
            "Lazarus, +1 armourer +2 charisma +8 strength (Rare enchanted) Lv. 25",
            "Leviathan, +2 armourer +4 charisma +8 strength (Rare enchanted) Lv. 28",
            "Dancer's, +2 cliff fall % (Common) Lv. 2",
            "Nomad's, +4 cliff fall % (Enchanted) Lv. 3",
            "Mountaineer's, +10 cliff fall % (Enchanted) Lv. 5",
            "Defender's, +5 parry % +1 agility (Enchanted) Lv. 9",
            "Unflinching, +10 parry % +2 agility (Enchanted) Lv. 12",
            "Mirrored, +20 parry % +4 agility (Rare enchanted) Lv. 19",
            "Garish, +2 health regeneration (Enchanted) Lv. 4",
            "Scarlet, +5 health regeneration (Enchanted) Lv. 8",
            "Burgandy [sic], +10 health regeneration (Rare enchanted) Lv. 14",
            "Crimson, +15 health regeneration +2 vitality (Rare enchanted) Lv. 27",
            "Ruby, +20 health regeneration +2 vitality (Rare enchanted) Lv. 33",
            "Garnet, +20 health (Rare enchanted) Lv. 16",
            "Claret, +40 health (Rare enchanted) Lv. 31",
            "Sunrise, +60 health (High rare enchanted) Lv. 46",
            "Titanic, +80 health +2 vitality (Epic) Lv. 67",
            "Atomic, +100 health +4 vitality (Epic) Lv. 74",
            "Azure, +2 magicka regeneration (Enchanted) Lv. 4",
            "Cobalt, +5 magicka regeneration (Enchanted) Lv. 8",
            "Cobalt, +10 magicka regeneration (Rare enchanted) Lv. 14",
            "Indigo, +15 magicka regeneration +2 intellect (Rare enchanted) Lv. 27",
            "Cerulean, +20 magicka regeneration +4 intellect (Rare enchanted) Lv. 36",
            "Infused, +20 magicka (Rare enchanted) Lv. 16",
            "Shimmering, +40 magicka (Rare enchanted) Lv. 31",
            "Chromatic, +60 magicka (High rare enchanted) Lv. 46",
            "Pagan's, +80 magicka +20 intellect (Epic) Lv. 67",
            "Bargle's, +100 magicka +4 intellect (Epic) Lv. 74",
            "Pewter, +2 dodge (Common) Lv. 2",
            "Silver, +5 dodge (Enchanted) Lv. 3",
            "Polished, +10 dodge +2 agility (Enchanted) Lv. 12",
            "Shining, +15 dodge +2 agility (Enchanted) Lv. 14",
            "Belgrave's, +20 dodge +4 agility (Rare enchanted) Lv. 19",
            "Winged, +10 walking speed +1 strength (Enchanted) Lv. 11",
            "Dove's, +20 walking speed +2 vitality (Enchanted) Lv. 16",
            "Falcon, +30 walking speed +3 vitality (Rare enchanted) Lv. 22",
            "Comet, +40 walking speed +4 vitality (Rare enchanted) Lv. 27",
            "Quark, +50 walking speed +5 vitality (Rare enchanted) Lv. 32",
            "Sargeant's [sic], +2 weapon speed (Common) Lv. 2",
            "Lieutenant's, +5 weapon speed (Enchanted) Lv. 3",
            "Captain's, +10 weapon speed +1 agility (Enchanted) Lv. 9",
            "Colonel's, +20 weapon speed +2 agility (Enchanted) Lv. 13",
            "General's, +30 weapon speed +4 agility (Rare enchanted) Lv. 19",
            "Sharp, +2 weapon min damage (Enchanted) Lv. 3",
            "Jagged, +5 weapon min damage (Enchanted) Lv. 6",
            "Branded, +10 weapon min damage +1 strength (Enchanted) Lv. 16",
            "Serrated, +20 weapon min damage +2 strength (Rare enchanted) Lv. 26",
            "Baleful, +30 weapon min damage +4 strength (Rare enchanted) Lv. 37",
            "Cruel, +2 weapon max damage (Enchanted) Lv. 5",
            "Wicked, +5 weapon max damage (Enchanted) Lv. 9",
            "Brutal, +10 weapon max damage +1 strength (Rare enchanted) Lv. 22",
            "Vindictive, +20 weapon max damage +2 strength (Rare enchanted) Lv. 38",
            "Neferious [sic], +30 weapon max damage +4 strength (Epic) Lv. 55",
            "Skilled, +2 chance to hit +1 walking speed (Enchanted) Lv. 11",
            "Talented, +5 chance to hit +2 walking speed (Rare enchanted) Lv. 19",
            "Veteran's, +10 chance to hit +5 walking speed (Rare enchanted) Lv. 32",
            "Expert's, +20 chance to hit +10 walking speed (Epic) Lv. 58",
            "Masterful, +25 chance to hit +20 walking speed (Epic) Lv. 74",
            "Bold, +2 defensive bonus +5 health regeneration (Enchanted) Lv. 17",
            "Trench, +5 defensive bonus +10 health regeneration (Rare enchanted) Lv. 30",
            "Retarius, +10 defensive bonus +15 health regeneration (High rare enchanted) Lv. 48",
            "Tyrant's, +20 defensive bonus +20 health regeneration (Epic) Lv. 74",
            "Helmguard's, +25 defensive bonus +25 health regeneration (Legendary) Lv. 74",
            "Yellow, +2 gold earnt % (Enchanted) Lv. 4",
            "Amber, +5 gold earnt % (Enchanted) Lv. 8",
            "Saffron, +10 gold earnt % +1 charisma (Rare enchanted) Lv. 19",
            "Goldenrod, +20 gold earnt % +2 charisma (Rare enchanted) Lv. 33",
            "Celen's, +40 gold earnt % +4 charisma (Epic) Lv. 60",
            "Goat, +5 experience earnt % (Rare enchanted) Lv. 14",
            "Manticore, +10 experience earnt % (Rare enchanted) Lv. 26",
            "Basilisk, +20 experience earnt % +1 intellect (Epic) Lv. 56",
            "Chimera, +40 experience earnt % +2 intellect (Legendary) Lv. 74",
            "Hydra, +50 experience earnt % +5 intellect (High legendary) Lv. 74",
            "Child's, -1 strength (Common) Lv. 2",
            "Sickly, -2 strength (Common) Lv. 2",
            "Crippling, -4 strength (Common) Lv. 2",
            "Hag's, -1 vitality (Common) Lv. 2",
            "Pox's, -2 vitality (Common) Lv. 2",
            "Bulbous, -4 vitality (Common) Lv. 2",
            "Foul, -1 charisma (Common) Lv. 2",
            "Hideous, -2 charisma (Common) Lv. 2",
            "Disgusting, -4 charisma (Common) Lv. 2",
            "Dunce's, -1 intellect (Common) Lv. 2",
            "Jester's, -2 intellect (Common) Lv. 2",
            "Moron's, -4 intellect (Common) Lv. 2",
            "Sluggish, -1 agility (Common) Lv. 2",
            "Lumbering, -2 agility (Common) Lv. 2",
            "Incapacitating, -4 agility (Common) Lv. 2",
            "Fire, +2 fire resist % (Enchanted) Lv. 6",
            "Fire, +5 fire damage (Rare enchanted) Lv. 14",
            "Fire, +10 fire damage (Rare enchanted) Lv. 26",
            "Fire, +20 fire damage (Epic) Lv. 50",
            "Fire, +40 fire damage (Legendary) Lv. 74",
            "Frost, +2 frost damage (Enchanted) Lv. 6",
            "Frost, +5 frost damage (Rare enchanted) Lv. 14",
            "Frost, +10 frost damage (Rare enchanted) Lv. 26",
            "Frost, +20 frost damage (Epic) Lv. 50",
            "Frost, +40 frost damage (Legendary) Lv. 74",
            "Lightning, +2 lightning damage (Enchanted) Lv. 6",
            "Lightning, +5 lightning damage (Rare enchanted) Lv. 14",
            "Lightning, +10 lightning damage (Rare enchanted) Lv. 26",
            "Lightning, +20 lightning damage (Epic) Lv. 50",
            "Lightning, +40 lightning damage (Legendary) Lv. 74",
            "Necromancy, +2 necromancy damage (Enchanted) Lv. 6",
            "Necromancy, +5 necromancy damage (Rare enchanted) Lv. 14",
            "Necromancy, +10 necromancy damage (Rare enchanted) Lv. 26",
            "Necromancy, +20 necromancy damage (Epic) Lv. 50",
            "Necromancy, +40 necromancy damage (Legendary) Lv. 74",
            "Poison, +2 poison damage (Enchanted) Lv. 6",
            "Poison, +5 poison damage (Rare enchanted) Lv. 14",
            "Poison, +10 poison damage (Rare enchanted) Lv. 26",
            "Poison, +20 poison damage (Epic) Lv. 50",
            "Poison, +40 poison damage (Legendary) Lv. 74"
                                                                      };
        public static readonly string[] ItemPrimaryEnchantmentIDs = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                                                      "10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
                                                                      "20", "21", "22", "23", "24", "25", "26", "27", "28", "29",
                                                                      "30", "31", "32", "33", "34", "35", "36", "37", "38", "39",
                                                                      "40", "41", "42", "43", "44", "45", "46", "47", "48", "49",
                                                                      "50", "51", "52", "53", "54", "55", "56", "57", "58", "59",
                                                                      "60", "61", "62", "63", "64", "65", "66", "67", "68", "69",
                                                                      "70", "71", "72", "73", "74", "75", "76", "77", "78", "79",
                                                                      "80", "81", "82", "83", "84", "85", "86", "87", "88", "89",
                                                                      "90", "91", "92", "93", "94", "95", "96", "97", "98", "99",
                                                                      "100", "101", "102", "103", "104", "105", "106", "107", "108", "109",
                                                                      "110", "111", "112", "113", "114", "115", "116", "117", "118", "119",
                                                                      "120", "121", "122", "123", "124", "125", "126", "127", "128", "129",
                                                                      "130", "131", "132", "133", "134", "135", "136", "137", "138", "139",
                                                                      "140", "141", "142", "143", "144", "145", "146", "147", "148", "149",
                                                                      "150", "151", "152", "153", "154", "155", "156", "157", "158", "159",
                                                                      "160", "161", "162", "163", "164", "165", "166", "167", "168", "169",
                                                                      "170", "171", "172", "173", "174", "175", "176", "177", "178", "179",
                                                                      "180", "181", "182", "183", "184", "185", "186", "187", "188", "189",
                                                                      "190", "191", "192", "193", "194", "195", "196", "197", "198", "199",
                                                                      "200", "201", "202", "203", "204", "205", "206", "207", "208", "209",
                                                                      "210", "211", "212", "213", "214", "215", "216", "217", "218", "219",
                                                                      "220", "221", "222", "223", "224", "225", "226", "227", "228", "229",
                                                                      "230", "231", "232", "233", "234", "235", "236", "237", "238", "239",
                                                                      "240", "241",
                                                                    };
        public static readonly string[] ItemSecondaryEnchantmentNames = {
            "N/A, (Common) Lv. 0",
            "The Boar, +1 strength (Enchanted) Lv. 3",
            "The Bear, +2 strength (Enchanted) Lv. 5",
            "The Babboon, +3 strength (Enchanted) Lv. 6",
            "The Ox, +4 strength (Enchanted) Lv. 7",
            "The Tiger, +5 strength (Enchanted) Lv. 9",
            "The Beast, +6 strength (Enchanted) Lv. 10",
            "The Ogre, +7 strength (Enchanted) Lv. 12",
            "Rending, +8 strength (Rare enchanted) Lv. 13",
            "The Giant, +9 strength (Rare enchanted) Lv. 15",
            "The Colossus, +10 strength (Rare enchanted) Lv. 16",
            "The Goldfish, +1 vitality (Enchanted) Lv. 3",
            "Will, +2 vitality (Enchanted) Lv. 5",
            "Oak, +3 vitality (Enchanted) Lv. 6",
            "The Roach, +4 vitality (Enchanted) Lv. 7",
            "The Plough, +5 vitality (Enchanted) Lv. 9",
            "Vigour, +6 vitality (Enchanted) Lv. 10",
            "The Mongoose, +7 vitality (Enchanted) Lv. 12",
            "Fortitude, +8 vitality (Rare enchanted) Lv. 13",
            "Perpetuity, +9 vitality (Rare enchanted) Lv. 15",
            "Immortality, +10 vitality (Rare enchanted) Lv. 16",
            "The Maiden, +1 charisma (Enchanted) Lv. 3",
            "Politics, +2 charisma (Enchanted) Lv. 5",
            "The Orator, +3 charisma (Enchanted) Lv. 6",
            "The Mind, +4 charisma (Enchanted) Lv. 7",
            "Blarney, +5 charisma (Enchanted) Lv. 9",
            "The Snake, +6 charisma (Enchanted) Lv. 10",
            "Tongues, +7 charisma (Enchanted) Lv. 12",
            "Sages, +8 charisma (Rare enchanted) Lv. 13",
            "Enigmas, +9 charisma (Rare enchanted) Lv. 15",
            "The Prophet, +10 charisma (Rare enchanted) Lv. 16",
            "Aptitude, +1 intellect (Enchanted) Lv. 3",
            "Cunning, +2 intellect (Enchanted) Lv. 5",
            "The Weasel, +3 intellect (Enchanted) Lv. 6",
            "The Beagle, +4 intellect (Enchanted) Lv. 7",
            "Lore, +5 intellect (Enchanted) Lv. 9",
            "Knowledge, +6 intellect (Enchanted) Lv. 10",
            "The Owl, +7 charisma (Enchanted) Lv. 12",
            "The Magi, +8 intellect (Rare enchanted) Lv. 13",
            "Wizardry, +9 intellect (Rare enchanted) Lv. 15",
            "Genius, +10 intellect (Rare enchanted) Lv. 16",
            "The Rhesus, +1 intellect (Enchanted) Lv. 3",
            "Haste, +2 intellect (Enchanted) Lv. 5",
            "The Fox, +3 intellect (Enchanted) Lv. 6",
            "Sparrows, +4 intellect (Enchanted) Lv. 7",
            "The Macaque, +5 intellect (Enchanted) Lv. 9",
            "The Cheetah, +6 intellect (Enchanted) Lv. 10",
            "The Ninja, +7 charisma (Enchanted) Lv. 12",
            "Moments, +8 intellect (Rare enchanted) Lv. 13",
            "Alacrity, +9 intellect (Rare enchanted) Lv. 15",
            "Incredible Haste, +10 intellect (Rare enchanted) Lv. 16",
            "Sharpness, +1 sword mastery +2 agility (Enchanted) Lv. 9",
            "Zen, +2 sword mastery +4 agility (Enchanted) Lv. 12",
            "Bludgeoning, +1 mace mastery +2 strength (Enchanted) Lv. 9",
            "Crushing, +2 mace mastery +4 strength (Enchanted) Lv. 12",
            "The Woods, +1 axe mastery +2 vitality (Enchanted) Lv. 9",
            "Splinters, +2 axe mastery +4 vitality (Enchanted) Lv. 12",
            "Vigilance, +1 polearm mastery +2 strength (Enchanted) Lv. 9",
            "Spires, +2 polearm mastery +4 strength (Enchanted) Lv. 12",
            "Cowards, +1 ranged weapon mastery +2 agility (Enchanted) Lv. 9",
            "Knaves, +2 ranged weapon mastery +4 agility (Enchanted) Lv. 12",
            "The Plains, +1 two handed weapon mastery +2 strength (Enchanted) Lv. 9",
            "Crushing, +2 two handed weapon mastery +4 strength (Enchanted) Lv. 12",
            "Duality, +1 dual wielding +2 agility (Enchanted) Lv. 9",
            "The Lotus, +2 dual wielding +4 agility (Enchanted) Lv. 12",
            "Gears, +1 gun mastery +2 agility (Enchanted) Lv. 9",
            "The Machine, +2 gun mastery +4 agility (Enchanted) Lv. 12",
            "Rumbling, +1 critical mastery +2 vitality (Enchanted) Lv. 9",
            "Tremors, +2 critical mastery +4 vitality (Enchanted) Lv. 12",
            "Gales, +1 whirlwind +2 agility (Enchanted) Lv. 9",
            "Storms, +2 whirlwind +4 agility (Enchanted) Lv. 12",
            "The Chalice, +1 magicka regeneration +2 agility (Enchanted) Lv. 9",
            "Pools, +2 magicka regeneration +4 agility (Enchanted) Lv. 12",
            "The Deep, +1 arcane lore +2 agility (Enchanted) Lv. 9",
            "The Abyss, +2 arcane lore +4 agility (Enchanted) Lv. 12",
            "Searing, +1 fire mastery +2 agility (Enchanted) Lv. 9",
            "The Volcano, +2 fire mastery +4 agility (Enchanted) Lv. 12",
            "Thunderbolts, +1 lightning mastery +2 agility (Enchanted) Lv. 9",
            "Shock, +2 lightning mastery +4 agility (Enchanted) Lv.  +12",
            "The Penguin, +1 frost mastery +2 agility (Enchanted) Lv. 9",
            "The Linnorn, +2 frost mastery +4 agility (Enchanted) Lv. 12",
            "Martyrs, +1 abjuration mastery +2 intellect (Enchanted) Lv. 9",
            "The Saint, +2 abjuration mastery +4 intellect (Enchanted) Lv. 12",
            "Dreams, +1 illusion mastery +2 intellect (Enchanted) Lv. 9",
            "Phantasms, +2 illusion mastery +4 intellect (Enchanted) Lv. 12",
            "Prisms, +1 poison mastery +2 intellect (Enchanted) Lv. 9",
            "The Void, +2 poison mastery +4 intellect (Enchanted) Lv. 12",
            "Sorrow, +1 necromancy mastery +2 agility (Enchanted) Lv. 9",
            "The Departed, +2 necromancy mastery +4 intellect (Enchanted) Lv. 12",
            "Casting, +1 essence +2 agility (Enchanted) Lv. 9",
            "Spells, +2 essence +4 agility (Enchanted) Lv. 12",
            "Worth, +1 mercantile +2 charisma (Enchanted) Lv. 9",
            "Wealth, +2 mercantile +4 charisma (Enchanted) Lv. 12",
            "The Serpent, +1 forked tongue +2 charisma (Enchanted) Lv. 9",
            "Usurping, +2 forked tongue +4 charisma (Enchanted) Lv. 12",
            "Soloing, +1 guitar mastery +2 intellect (Enchanted) Lv. 9",
            "Harmonics, +2 guitar mastery +4 intellect (Enchanted) Lv. 12",
            "The Ark, +1 archaeology +2 vitality (Enchanted) Lv. 9",
            "Discovery, +2 archaeology +4 vitality (Enchanted) Lv. 12",
            "Noise, +1 distortion +2 charisma (Enchanted) Lv. 9",
            "Six Strings, +2 distortion +4 charisma (Enchanted) Lv. 12",
            "Echoes, +1 amplify +2 charisma (Enchanted) Lv. 9",
            "Deafening, +2 amplify +4 charisma (Enchanted) Lv. 12",
            "Nirvana, +1 serenity +2 charisma (Enchanted) Lv. 9",
            "Zen, +2 serenity +4 charisma (Enchanted) Lv. 12",
            "Adoration, +1 shred +2 intellect (Enchanted) Lv. 9",
            "Big Hair, +2 shred +4 intellect (Enchanted) Lv. 12",
            "Music, +1 virtuoso +2 charisma (Enchanted) Lv. 9",
            "Wondrous Sounds, +2 virtuoso +4 charisma (Enchanted) Lv. 12",
            "The Lily, +1 people's champion +2 charisma (Enchanted) Lv. 9",
            "The Rose, +2 people's champion +4 charisma (Enchanted) Lv. 12",
            "The Tulip, +1 acrobatics +2 agility (Enchanted) Lv. 9",
            "Laurels, +2 acrobatics +4 agility (Enchanted) Lv. 12",
            "The Dwarf, +1 dodge mastery +2 agility (Enchanted) Lv. 9",
            "Anguish, +2 dodge mastery +4 agility (Enchanted) Lv. 12",
            "Runes, +1 conviction +2 charisma (Enchanted) Lv. 9",
            "Betrayal, +2 conviction +4 charisma (Enchanted) Lv. 12",
            "Nature, +1 parrying mastery +2 charisma (Enchanted) Lv. 9",
            "Nature's Blessing, +2 parrying mastery +4 charisma (Enchanted) Lv. 12",
            "Walls, +1 elemental resistance +2 charisma (Enchanted) Lv. 9",
            "Crashing Waves, +2 elemental resistance +4 charisma (Enchanted) Lv. 12",
            "Leonidas, +1 shield mastery +2 charisma (Enchanted) Lv. 9",
            "Spartans, +2 shield mastery +4 charisma (Enchanted) Lv. 12",
            "Boulders, +1 immovable +2 charisma (Enchanted) Lv. 9",
            "Mountains, +2 immovable +4 charisma (Enchanted) Lv. 12",
            "Extra Life, +1 robust constitution +2 charisma (Enchanted) Lv. 9",
            "Gaia, +2 robust constitution +4 charisma (Enchanted) Lv. 12",
            "Iron, +1 armourer +2 charisma (Enchanted) Lv. 9",
            "Steel, +2 armourer +4 charisma (Enchanted) Lv. 12",
            "Mighty Hero, +1 armourer +2 charisma +8 strength (Rare enchanted) Lv. 25",
            "Eternal Warrior, +2 armourer +4 charisma +8 strength (Rare enchanted) Lv. 28",
            "Mountain Goat, +2 cliff fall % (Common) Lv. 2",
            "Great Heights, +4 cliff fall % (Enchanted) Lv. 3",
            "Vertigo, +10 cliff fall % (Enchanted) Lv. 5",
            "Deflection, +5 parry % +1 agility (Enchanted) Lv. 9",
            "Guardian, +10 parry % +2 agility (Enchanted) Lv. 12",
            "Radiance, +20 parry % +4 agility (Rare enchanted) Lv. 19",
            "Healing, +2 health regeneration (Enchanted) Lv. 4",
            "Recuperation, +5 health regeneration (Enchanted) Lv. 8",
            "Regeneration, +10 health regeneration (Rare enchanted) Lv. 14",
            "Replentishing [sic], +15 health regeneration +2 vitality (Rare enchanted) Lv. 27",
            "Undying, +20 health regeneration +2 vitality (Rare enchanted) Lv. 33",
            "Sturdiness, +20 health (Rare enchanted) Lv. 16",
            "Wolf, +40 health (Rare enchanted) Lv. 31",
            "Red Dawns, +60 health (High rare enchanted) Lv. 46",
            "Whale, +80 health +2 vitality (Epic) Lv. 67",
            "Two Strong Hearts, +100 health +4 vitality (Epic) Lv. 74",
            "Mana Flow, +2 magicka regeneration (Enchanted) Lv. 4",
            "Rivers, +5 magicka regeneration (Enchanted) Lv. 8",
            "Dark Crystals, +10 magicka regeneration (Rare enchanted) Lv. 14",
            "The Witch, +15 magicka regeneration +2 intellect (Rare enchanted) Lv. 27",
            "The Conclave, +20 magicka regeneration +4 intellect (Rare enchanted) Lv. 36",
            "The Cat, +20 magicka (Rare enchanted) Lv. 16",
            "The Toad, +40 magicka (Rare enchanted) Lv. 31",
            "Shadows, +60 magicka (High rare enchanted) Lv. 46",
            "Midnight, +80 magicka +20 intellect (Epic) Lv. 67",
            "Artifice, +100 magicka +4 intellect (Epic) Lv. 74",
            "The Hamster, +2 dodge (Common) Lv. 2",
            "Avoidance, +5 dodge (Enchanted) Lv. 3",
            "The Ginger, +10 dodge +2 agility (Enchanted) Lv. 12",
            "Reflex, +15 dodge +2 agility (Enchanted) Lv. 14",
            "Eluding, +20 dodge +4 agility (Rare enchanted) Lv. 19",
            "Quickness, +10 walking speed +1 strength (Enchanted) Lv. 11",
            "Pace, +20 walking speed +2 vitality (Enchanted) Lv. 16",
            "The Nimble, +30 walking speed +3 vitality (Rare enchanted) Lv. 22",
            "Velocity, +40 walking speed +4 vitality (Rare enchanted) Lv. 27",
            "Blinding Speed, +50 walking speed +5 vitality (Rare enchanted) Lv. 32",
            "Striking, +2 weapon speed (Common) Lv. 2",
            "The Jackal, +5 weapon speed (Enchanted) Lv. 3",
            "The Trapjaw, +10 weapon speed +1 agility (Enchanted) Lv. 9",
            "The Ram, +20 weapon speed +2 agility (Enchanted) Lv. 13",
            "Execution, +30 weapon speed +4 agility (Rare enchanted) Lv. 19",
            "Ouchies, +2 weapon min damage (Enchanted) Lv. 3",
            "Hurting, +5 weapon min damage (Enchanted) Lv. 6",
            "Wounds, +10 weapon min damage +1 strength (Enchanted) Lv. 16",
            "Abrasion, +20 weapon min damage +2 strength (Rare enchanted) Lv. 26",
            "Deep Wounds, +30 weapon min damage +4 strength (Rare enchanted) Lv. 37",
            "Pain, +2 weapon max damage (Enchanted) Lv. 5",
            "Grief, +5 weapon max damage (Enchanted) Lv. 9",
            "Suffering (weapon), The Tuna (armor), +10 weapon max damage +1 strength (Rare enchanted) Lv. 22",
            "Torture, +20 weapon max damage +2 strength (Rare enchanted) Lv. 38",
            "Agony, +30 weapon max damage +4 strength (Epic) Lv. 55",
            "Skirmishes, +2 chance to hit +1 walking speed (Enchanted) Lv. 11",
            "Combat, +5 chance to hit +2 walking speed (Rare enchanted) Lv. 19",
            "Battle, +10 chance to hit +5 walking speed (Rare enchanted) Lv. 32",
            "Conflict, +20 chance to hit +10 walking speed (Epic) Lv. 58",
            "Epic Battle, +25 chance to hit +20 walking speed (Epic) Lv. 74",
            "Insolence, +2 defensive bonus +5 health regeneration (Enchanted) Lv. 17",
            "The Bison, +5 defensive bonus +10 health regeneration (Rare enchanted) Lv. 30",
            "Recurrence, +10 defensive bonus +15 health regeneration (High rare enchanted) Lv. 48",
            "Enslavement, +20 defensive bonus +20 health regeneration (Epic) Lv. 74",
            "The Iron Fist, +25 defensive bonus +25 health regeneration (Legendary) Lv. 74",
            "Greed, +2 gold earnt % (Enchanted) Lv. 4",
            "Riches, +5 gold earnt % (Enchanted) Lv. 8",
            "Prosperity, +10 gold earnt % +1 charisma (Rare enchanted) Lv. 19",
            "Treasure, +20 gold earnt % +2 charisma (Rare enchanted) Lv. 33",
            "Infinite Wealth, +40 gold earnt % +4 charisma (Epic) Lv. 60",
            "Experience, +5 experience earnt % (Rare enchanted) Lv. 14",
            "Remembrance, +10 experience earnt % (Rare enchanted) Lv. 26",
            "Reknow, +20 experience earnt % +1 intellect (Epic) Lv. 56",
            "Portals, +40 experience earnt % +2 intellect (Legendary) Lv. 74",
            "The Pantheon, +50 experience earnt % +5 intellect (High legendary) Lv. 74",
            "Weakness, -1 strength (Common) Lv. 2",
            "The Weakling, -2 strength (Common) Lv. 2",
            "The Invalid, -4 strength (Common) Lv. 2",
            "Wasting, -1 vitality (Common) Lv. 2",
            "Plague, -2 vitality (Common) Lv. 2",
            "Pestilence, -4 vitality (Common) Lv. 2",
            "Ugliness, -1 charisma (Common) Lv. 2",
            "The Wart, -2 charisma (Common) Lv. 2",
            "The Poodle, -4 charisma (Common) Lv. 2",
            "The Simpleton, -1 intellect (Common) Lv. 2",
            "The Idiot, -2 intellect (Common) Lv. 2",
            "Incompetence, -4 intellect (Common) Lv. 2",
            "The Snail, -1 agility (Common) Lv. 2",
            "The Sloth, -2 agility (Common) Lv. 2",
            "Immobility, -4 agility (Common) Lv. 2",
            "Fire Resistance, +2% fire resist (Enchanted) Lv. 6",
            "Fire Resistance, +4% fire resist (Rare enchanted) Lv. 14",
            "Fire Resistance, +10% fire resist (Rare enchanted) Lv. 26",
            "Fire Resistance, +15% fire resist (Epic) Lv. 50",
            "Fire Resistance, +20% fire resist (Legendary) Lv. 74",
            "Frost Resistance, +2% frost resist (Enchanted) Lv. 6",
            "Frost Resistance, +4% frost resist (Rare enchanted) Lv. 14",
            "Frost Resistance, +10% frost resist (Rare enchanted) Lv. 26",
            "Frost Resistance, +15% frost resist (Epic) Lv. 50",
            "Frost Resistance, +20% frost resist (Legendary) Lv. 74",
            "Lightning Resistance, +2% lightning resist (Enchanted) Lv. 6",
            "Lightning Resistance, +4% lightning resist (Rare enchanted) Lv. 14",
            "Lightning Resistance, +10% lightning resist (Rare enchanted) Lv. 26",
            "Lightning Resistance, +15% lightning resist (Epic) Lv. 50",
            "Lightning Resistance, +20% lightning resist (Legendary) Lv. 74",
            "Necromancy Resistance, +2% necromancy resist (Enchanted) Lv. 6",
            "Necromancy Resistance, +4% necromancy resist (Rare enchanted) Lv. 14",
            "Necromancy Resistance, +10% necromancy resist (Rare enchanted) Lv. 26",
            "Necromancy Resistance, +15% necromancy resist (Epic) Lv. 50",
            "Necromancy Resistance, +20% necromancy resist (Legendary) Lv. 74",
            "Poison Resistance, +2% poison resist (Enchanted) Lv. 6",
            "Poison Resistance, +4% poison resist (Rare enchanted) Lv. 14",
            "Poison Resistance, +10% poison resist (Rare enchanted) Lv. 26",
            "Poison Resistance, +15% poison resist (Epic) Lv. 50",
            "Poison Resistance, +20% poison resist (Legendary) Lv. 74"
                                                                        };
        public static readonly string[] ItemSecondaryEnchantmentIDs = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                                                       "10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
                                                                       "20", "21", "22", "23", "24", "25", "26", "27", "28", "29",
                                                                       "30", "31", "32", "33", "34", "35", "36", "37", "38", "39",
                                                                       "40", "41", "42", "43", "44", "45", "46", "47", "48", "49",
                                                                       "50", "51", "52", "53", "54", "55", "56", "57", "58", "59",
                                                                       "60", "61", "62", "63", "64", "65", "66", "67", "68", "69",
                                                                       "70", "71", "72", "73", "74", "75", "76", "77", "78", "79",
                                                                       "80", "81", "82", "83", "84", "85", "86", "87", "88", "89",
                                                                       "90", "91", "92", "93", "94", "95", "96", "97", "98", "99",
                                                                       "100", "101", "102", "103", "104", "105", "106", "107", "108", "109",
                                                                       "110", "111", "112", "113", "114", "115", "116", "117", "118", "119",
                                                                       "120", "121", "122", "123", "124", "125", "126", "127", "128", "129",
                                                                       "130", "131", "132", "133", "134", "135", "136", "137", "138", "139",
                                                                       "140", "141", "142", "143", "144", "145", "146", "147", "148", "149",
                                                                       "150", "151", "152", "153", "154", "155", "156", "157", "158", "159",
                                                                       "160", "161", "162", "163", "164", "165", "166", "167", "168", "169",
                                                                       "170", "171", "172", "173", "174", "175", "176", "177", "178", "179",
                                                                       "180", "181", "182", "183", "184", "185", "186", "187", "188", "189",
                                                                       "190", "191", "192", "193", "194", "195", "196", "197", "198", "199",
                                                                       "200", "201", "202", "203", "204", "205", "206", "207", "208", "209",
                                                                       "210", "211", "212", "213", "214", "215", "216", "217", "218", "219",
                                                                       "220", "221", "222", "223", "224", "225", "226", "227", "228", "229",
                                                                       "230", "231", "232", "233", "234", "235", "236", "237", "238", "239",
                                                                       "240", "241",
                                                                      };
        #endregion
    }

    public class ArenaChampions {
        public static readonly string TheFearfulPrisoner = "0,123,The Fearful Prisoner,4,0,0,I am not afraid anymore!,I'll be damned if you are loss number 10,000!,0,0,0,0,0,0,0,0,A,0,0,0,0,0,2_2_31_1_0_2,3_3_0_1_0_2,0,0,6_6_31_1_0_2,7_7_0_1_0_2,0,0,10_12_0_96_0_2,11_11_0_1_0_2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string BoarhideTraderPigsus = "0,123,Boarhide Trader Pigsus,7,0,0,Ooooh...me gizzards. Help me out; fella. How about dying nice and quick like?,This little piggy went to market and sold your skin as fine pair of boots. Oink; oink.,0,0,0,0,1_11_1_34_72.5_95_6_6_2_2_2_2_40,0,0,0,A,0,0,0_16_15_37_45,0,1_1_0_19_0_0,2_2_0_3_0_0,3_3_0_3_0_0,4_4_0_3_0_0,0,6_6_0_3_0_0,7_7_0_3_0_0,0,0,10_12_1_95_1_0,11_11_11_3_0_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string XanfarTheHaunted = "0,123,Xanfar The Haunted,10,0,0,The bells of death toll but my soul can find no rest... I yearn for the grave!,The cruel embrace of undeath awaits there.,0,0,0,0,21_6_1_1_60_30_3_18_4_4_4_2_-60,0,0,0,A,0,0,0,0,1_1_0_2_0_-4,2_2_31_1_0_-4,3_3_57_1_0_-4,4_4_0_4_81_-4,0,6_6_0_1_0_-4,7_7_0_1_0_-4,0,10_12_233_93_232_-4,10_12_233_93_232_-4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string Obliterator9000 = "0,123,Obliterator 9000,13,0,0,You are an inferior lifeform and must be obliterated.,Obliteration complete. Press ESC to empty recycle bin.,0,0,0,0,24_6_1_1_80_50_18_18_7_7_7_2_0,0,0,0,A,0,0,0,0,0,0,0,0,0,0,0,0,0,10_12_28_77_0_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string MrOmazing = "0,123,Mr Omazing,16,0,0,You work for Mr Omazing now.,Mr Omazing only has time for winners.,0,0,0,0,3_6_1_35_45_35_9_9_1_1_1_2_-180,0,0,0,A,0,0,0_16_15_14_13_36_32_47,0,1_1_0_23_80_0,2_2_0_4_0_3,3_3_224_2_80_0,4_4_224_2_80_0,0,6_6_80_4_0_-20,7_7_0_4_0_4,0,0,10_12_80_13_224_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string TheYetiProject = "0,123,The Yeti Project,19,0,0,Yeti make yellow snowcone for you!,Yeti tired and want to go home!,0,0,0,0,20_6_1_1_140_140_15_15_5_5_5_2_0,0,0,0,A,0,0,0,0,1_1_168_12_0_0,2_2_0_9_0_0,0,0,0,6_6_0_9_162_0,0,0,0,10_12_226_97_226_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string BattlemaidenAnna = "0,123,Battlemaiden Anna,22,0,0,You will not stop my quest. Step aside; gladiator.,Where are you Arglaxx? I will have my revenge.,0,0,0,0,9_10_29_1_55_40_1_1_10_10_10_2_20,0,0,0,A,0,0,0_36_37_44_52_33,0,0,2_2_18_5_0_0,3_3_112_5_0_0,4_4_87_5_0_0,0,6_6_0_5_130_0,7_7_187_5_0_0,0,0,10_12_200_59_30_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string Fizzacles = "0,123,Fizzacles,25,0,0,Fizzzzzzzzzzz.....,Fo Shizzle; Fizzle.,0,0,0,0,12_6_1_1_65_55_18_18_9_9_9_2_0,0,0,0,A,0,0,0_11_10_9_35_32_40_49_52,0_12,1_1_230_3_149_0,2_2_0_2_0_0,3_3_0_2_28_0,4_4_0_2_0_0,0,6_6_0_2_230_0,7_7_0_2_0_0,0,0,10_12_231_98_230_0,11_11_226_2_0_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string SirBrianOfMay = "0,123,Sir Brian of May,28,0,0,Here we stand; here we fall. History won't care at all.,Another one bites the dust!,0,0,0,0,2_3_22_1_55_35_2_2_1_1_1_2_30,0,0,0,A,0,0,0_42_38_32_52,0,0,2_2_47_7_58_0,3_3_0_7_0_38,4_4_0_7_0_38,0,6_6_0_7_0_38,7_7_105_7_105_38,0,0,10_12_106_99_106_0,11_11_0_3_0_38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string Arglaxx = "0,123,Arglaxx,31,0,0,You'll never make a monkey out of me!,The Beast Force will return and the apes will once again rule this land!,0,0,0,0,24_13_48_25_85_100_12_12_2_2_2_2_-215,0,0,0,A,0,0,0_45_53_31,0,1_1_0_10_63_0,2_2_0_6_1_0,3_3_0_6_219_0,4_4_0_6_146_0,0,6_6_180_6_46_-98,7_7_0_6_121_0,0,9_10_0_6_0_-200,10_12_241_100_186_-50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string TheBoneslinger = "0,123,The Boneslinger,34,0,0,I shall feast on your rooting corpse; gladiator.,Hatred courses trough me; feeding the void that once was my soul.,0,0,0,0,10_8_1_1_62.5_30_15_18_11_11_11_2_-30,0,0,0,A,0,0,0_36_45_27_51_43,0,1_1_0_11_232_0,2_2_189_5_211_0,3_3_0_5_136_0,4_4_0_5_0_-50,0,6_6_0_5_76_0,7_7_0_5_143_0,0,0,10_12_0_72_190_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string ArchfiendCoalbhaal = "0,123,Archfiend Coalbhaal,37,0,0,Burn... feel the flame's warm embrace.,Fire flickers; burns with rage and dies and all that remains are the ashes of memory.,0,0,0,0,15_12_20_30_72.5_30_7_7_3_3_3_2_-50,0,0,0,A,0,0,0_46_33_6_5_4_3_40_39,0,1_1_0_17_0_-50,2_2_0_8_0_-50,3_3_0_8_0_-50,4_4_5_8_0_-50,0,6_6_5_8_0_-50,7_7_5_8_0_-50,0,9_10_87_3_122_-50,10_12_155_11_74_-50,11_11_65_6_0_-50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string Bladetronv20 = "0,123,Bladetron v2.0,40,0,0,11101100... You are an inferior lifeform...01110110!,Bladetron v2.0 has encountered a software error and must be restarted. ,0,0,0,0,11_6_1_1_80_50_18_18_7_7_7_2_0,0,0,0,A,0,0,0,0,1_1_182_27_163_0,0,0,0,0,0,0,0,10_12_231_94_0_0,10_12_231_94_0_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string MossoclesTheVenimous = "0,123,Mossocles the Venomous,43,0,0,Who can resist the call of nature.,Soon you will become one with the earth,0,0,0,0,8_6_1_1_150_130_18_18_8_8_8_2_-35,0,0,0,A,0,0,0_38_45_52_26_50,0,0,2_2_233_5_208_0,3_3_3_9_241_0,4_4_240_9_5_0,0,6_6_240_9_0_0,7_7_241_9_240_0,0,0,10_12_241_101_118_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string GreatKnightGallantrus = "0,123,Great Knight Gallantrus,46,0,0,You fight vallianty; my friend.,This was a glorious battle and the bards shall sing of you.,0,0,0,0,2_12_1_39_58_60_1_1_1_1_1_2_460,0,0,0,A,0,0,0_32_44_41,0,1_1_0_24_144_0,2_2_191_10_191_75,3_3_87_10_143_0,4_4_87_10_143_0,0,6_6_0_10_138_50,7_7_87_10_143_0,0,0,10_12_221_20_0_0,11_11_186_2_92_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string Bargle = "0,123,Bargle,49,0,0,The ways of sorcery are not for the weak.,The doors of knowledge shall not be opened by you; friend.,0,0,0,0,2_23_25_24_38_5_1_18_1_1_3_2_500,0,0,0,A,0,0,0_35_34_18_11_5_22_45,0,0,2_2_156_2_0_0,3_3_10_2_90_0,4_4_10_2_90_0,0,6_6_10_2_90_0,7_7_10_2_90_0,0,10_12_230_102_156_0,10_12_235_102_156_0,11_11_0_4_0_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string Platos = "0,123,Platos,52,0,0,Tremble; mortal.,The way is shut.,0,0,0,0,22_6_1_1_210_210_1_18_6_6_6_2_0,0,0,0,A,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string EvilNinjaRedux = "0,123,Evil Ninja Redux,55,0,0,Yum cha showdnown; fun for you and for me!,Yum cha showdnown; oh do have some tea!,0,0,0,0,24_6_1_1_0_0_18_18_9_9_9_2_-541,0,0,0,A,0,0,0,0,1_1_236_13_199_-90,2_2_199_2_0_-90,3_3_199_2_0_-90,4_4_199_2_0_-90,0,6_6_199_2_0_-90,7_7_199_2_0_-90,0,10_12_225_92_72_-90,10_12_225_92_72_-90,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string MagnificentLeopold = "0,123,Magnificent Leopold,58,0,0,I am the Lord of the Dance!,A song in thy honour... the Requiem of the of Hapless Ineptitude.,0,0,0,0,16_6_17_1_43_30_10_10_3_3_3_2_541,0,0,0,A,0,0,0_42_33_35_38_51_45,0,0,2_2_157_5_27_0,3_3_77_5_0_0,4_4_60_5_101_0,0,6_6_98_5_159_0,7_7_98_5_159_0,0,0,10_12_0_89_201_0,11_11_111_2_74_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string FatherPainbringer = "0,123,Father Painbringer,61,0,0,Bring the pain!,Hey; how would you like 10% off all guns at the Laser Emporium? Tomorrow only!,0,0,0,0,2_6_1_2_60_60_1_1_1_1_1_2_541,0,0,0,A,0,0,0,0,1_1_9_28_139_50,2_2_0_11_139_50,3_3_0_11_235_50,4_4_0_11_139_50,0,6_6_0_11_139_50,7_7_0_11_139_50,0,0,10_12_231_79_10_50,11_11_0_5_139_50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string BluescreenDeath = "0,123,Bluescreen Death,64,0,0,CTRL + ALT + DELETE,Faults in your skills have caused your life system to crash. You will now be deleted.,0,0,0,0,5_6_1_1_125_120_18_18_7_7_7_2_0,0,0,0,A,0,0,0,0,1_1_185_15_169_0,0,0,0,0,0,0,0,10_12_231_103_0_0,10_12_231_103_0_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string TheUndeadGreatBeast = "0,123,The Undead Great Beast,67,0,0,The bell tolls; the shadows grow. Flee while you can.,One does not gaze upon the face of death and live.,0,0,0,0,3_6_1_1_250_250_8_18_11_11_11_2_-541,0,0,0,A,0,0,0,0,1_1_16_30_226_-50,2_2_142_3_226_-126,3_3_169_3_0_-149,4_4_10_3_169_-25,0,6_6_0_3_167_-30,7_7_39_3_17_-153,0,0,10_12_104_104_156_-142,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string FallenEmperorAntares = "0,123,Fallen Emperor Antares,70,0,0,I have returned....this world shall be mine!,Tremble; mortal; for you shall not find respite in death.,0,0,0,0,18_6_29_18_130_100_7_18_4_4_4_2_-541,0,0,0,A,0,0,0,0,1_1_220_20_88_0,2_2_220_11_88_0,3_3_220_11_88_0,4_4_220_11_88_0,0,6_6_220_11_88_0,7_7_220_11_88_0,0,9_10_220_7_88_0,10_12_196_105_15_0,11_11_220_4_88_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public static readonly string UltratusOmega = "0,123,Ultratus Omega,75,0,0,Are you worthy to join us in immortallity?,You showed much promise. A great shame that you stumbled here at the end.,0,0,0,0,15_6_1_1_150_150_18_18_7_7_7_7_0,0,0,0,A,0,0,0_44_52_36_34_12_13_38,0,1_1_146_32_186_0,0,3_3_146_11_186_0,0,0,0,7_7_146_11_186_0,0,10_12_184_106_181_0,10_12_184_106_181_0,11_11_146_7_186_0,0,2_2_146_11_186_0,4_4_146_11_186_0,6_6_146_11_186_0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
    }
}
