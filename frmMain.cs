using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SwordsAndSandals3Editor {
    public partial class frmMain : Form {
        Gladiator Loaded = new Gladiator();
        int ItemLoaded = -1;            // Determines what item is loaded.
        bool DisableItemSave = false;   // Determines if a item is being loaded or a inventory slot is being disabled.

        bool FileLoaded = false;        // Determines if a file was loaded.
        int FileType = -1;              // Determines what file type was loaded, 0 = FlashSharedObject, 1 = SQLite, -1 = No file loaded.
        //string FileString = null;       // The string of the file (if using FlashSharedObject).
        byte[] FileByte;
        string FileLocation = null;     // The location of the file.
        List<string> GladiatorsList = new List<string>();   // The unparsed gladiators from the file.

        public frmMain() {
            InitializeComponent();
            cbInventoryEnchantment1.Items.AddRange(Items.ItemPrimaryEnchantmentNames);
            cbInventoryEnchantment2.Items.AddRange(Items.ItemSecondaryEnchantmentNames);
        }

        private void LoadSchoolTree(int SchoolID, string SchoolData) {
            string[] Data = SchoolData.Split('_');
            if (Data.Length == 10 + 9) {
                switch (SchoolID) {
                    case 0: // Warfare
                        txtWarfareSwordMastery.Text = Data[0];
                        txtWarfareMaceMastery.Text = Data[1];
                        txtWarfareAxeMastery.Text = Data[2];
                        txtWarfarePolearmMastery.Text = Data[3];
                        txtWarfareRangedMastery.Text = Data[4];
                        txtWarfare2HandedMastery.Text = Data[5];
                        txtWarfareDualWielding.Text = Data[6];
                        txtWarfareGunMastery.Text = Data[7];
                        txtWarfareCriticalMastery.Text = Data[8];
                        txtWarfareWhirlwind.Text = Data[9];
                        break;
                    case 1: // Arcane
                        txtArcaneMagickaRegeneration.Text = Data[0];
                        txtArcaneArcaneLore.Text = Data[1];
                        txtArcaneFireMastery.Text = Data[2];
                        txtArcaneLightningMastery.Text = Data[3];
                        txtArcaneFrostMastery.Text = Data[4];
                        txtArcaneAbjurationMastery.Text = Data[5];
                        txtArcaneIllusionMastery.Text = Data[6];
                        txtArcanePoisonMastery.Text = Data[7];
                        txtArcaneNecromancyMastery.Text = Data[8];
                        txtArcaneEssence.Text = Data[9];
                        break;
                    case 2: // Theatrics
                        txtTheatricsMercantile.Text = Data[0];
                        txtTheatricsForkedTongue.Text = Data[1];
                        txtTheatricsGuitarMastery.Text = Data[2];
                        txtTheatricsArchaeology.Text = Data[3];
                        txtTheatricsDistortion.Text = Data[4];
                        txtTheatricsAmplify.Text = Data[5];
                        txtTheatricsSerenity.Text = Data[6];
                        txtTheatricsShred.Text = Data[7];
                        txtTheatricsVirtuoso.Text = Data[8];
                        txtTheatricsPeoplesChampion.Text = Data[9];
                        break;
                    case 3: // Survival
                        txtSurvivalAcrobatics.Text = Data[0];
                        txtSurvivalDodgeMastery.Text = Data[1];
                        txtSurvivalConviction.Text = Data[2];
                        txtSurvivalParryingMastery.Text = Data[3];
                        txtSurvivalElementalResistance.Text = Data[4];
                        txtSurvivalShieldMastery.Text = Data[5];
                        txtSurvivalImmovable.Text = Data[6];
                        txtSurvivalRobustConstitution.Text = Data[7];
                        txtSurvivalArmourer.Text = Data[8];
                        txtSurvivalJuggernaut.Text = Data[9];
                        break;
                }
            }
        }
        private string SaveSchoolTree(int SchoolID) {
            string Data = null;
            switch (SchoolID) {
                case 0: // Warfare
                    Data = txtWarfareSwordMastery.Text + "_" +
                    txtWarfareMaceMastery.Text + "_" +
                    txtWarfareAxeMastery.Text + "_" +
                    txtWarfarePolearmMastery.Text + "_" +
                    txtWarfareRangedMastery.Text + "_" +
                    txtWarfare2HandedMastery.Text + "_" +
                    txtWarfareDualWielding.Text + "_" +
                    txtWarfareGunMastery.Text + "_" +
                    txtWarfareCriticalMastery.Text + "_" +
                    txtWarfareWhirlwind.Text;
                    break;
                case 1: // Arcane
                    Data = txtArcaneMagickaRegeneration.Text + "_" +
                    txtArcaneArcaneLore.Text + "_" +
                    txtArcaneFireMastery.Text + "_" +
                    txtArcaneLightningMastery.Text + "_" +
                    txtArcaneFrostMastery.Text + "_" +
                    txtArcaneAbjurationMastery.Text + "_" +
                    txtArcaneIllusionMastery.Text + "_" +
                    txtArcanePoisonMastery.Text + "_" +
                    txtArcaneNecromancyMastery.Text + "_" +
                    txtArcaneEssence.Text;
                    break;
                case 2: // Theatrics
                    Data = txtTheatricsMercantile.Text + "_" +
                    txtTheatricsForkedTongue.Text + "_" +
                    txtTheatricsGuitarMastery.Text + "_" +
                    txtTheatricsArchaeology.Text + "_" +
                    txtTheatricsDistortion.Text + "_" +
                    txtTheatricsAmplify.Text + "_" +
                    txtTheatricsSerenity.Text + "_" +
                    txtTheatricsShred.Text + "_" +
                    txtTheatricsVirtuoso.Text + "_" +
                    txtTheatricsPeoplesChampion.Text;
                    break;
                case 3: // Survival
                    Data = txtSurvivalAcrobatics.Text + "_" +
                    txtSurvivalDodgeMastery.Text + "_" +
                    txtSurvivalConviction.Text + "_" +
                    txtSurvivalParryingMastery.Text + "_" +
                    txtSurvivalElementalResistance.Text + "_" +
                    txtSurvivalShieldMastery.Text + "_" +
                    txtSurvivalImmovable.Text + "_" +
                    txtSurvivalRobustConstitution.Text + "_" +
                    txtSurvivalArmourer.Text + "_" +
                    txtSurvivalJuggernaut.Text;
                    break;
            }
            return Data;
        }
        private void LoadItem(string ItemData) {
            SaveItem();
            DisableItemSave = true;

            cbInventoryItemType.SelectedIndex = -1;
            cbInventoryEnchantment1.SelectedIndex = -1;
            cbInventoryEnchantment2.SelectedIndex = -1;

            if (ItemData == "0") {
                Loaded.LoadedInventoryType = null;
                Loaded.LoadedInventoryEnchantment1 = null;
                Loaded.LoadedInventoryItem = null;
                Loaded.LoadedInventoryEnchantment2 = null;
                Loaded.LoadedInventoryAlignment = null;
                txtRawItem.Text = ItemData;
                cbInventoryItem.SelectedIndex = -1;
                cbInventoryItem.Items.Clear();
            }
            else {
                int DatabaseID = -1;
                int ItemIndex = -1;
                string[] Data = ItemData.Split('_');
                Loaded.LoadedInventoryType = Data[0] + "_" + Data[1];
                Loaded.LoadedInventoryEnchantment1 = Data[2];
                Loaded.LoadedInventoryItem = Data[3];
                Loaded.LoadedInventoryEnchantment2 = Data[4];
                Loaded.LoadedInventoryAlignment = Data[5];
                txtRawItem.Text = ItemData;

                cbInventoryEnchantment1.SelectedIndex = Array.FindIndex(Items.ItemPrimaryEnchantmentIDs, x => x == Data[2]);
                switch (Data[0] + "_" + Data[1]) {
                    case "1_1":
                        ItemIndex = Array.FindIndex(Items.HelmetIDs, x => x == Data[3]);
                        cbInventoryItemType.SelectedIndex = 0;
                        DatabaseID = 0;
                        break;
                    case "2_2":
                        ItemIndex = Array.FindIndex(Items.ArmorIDs, x => x == Data[3]);
                        cbInventoryItemType.SelectedIndex = 1;
                        DatabaseID = 1;
                        break;
                    case "3_3":
                        ItemIndex = Array.FindIndex(Items.ArmorIDs, x => x == Data[3]);
                        cbInventoryItemType.SelectedIndex = 2;
                        DatabaseID = 2;
                        break;
                    case "4_4":
                        ItemIndex = Array.FindIndex(Items.ArmorIDs, x => x == Data[3]);
                        cbInventoryItemType.SelectedIndex = 3;
                        DatabaseID = 3;
                        break;
                    case "6_6":
                        ItemIndex = Array.FindIndex(Items.ArmorIDs, x => x == Data[3]);
                        cbInventoryItemType.SelectedIndex = 4;
                        DatabaseID = 4;
                        break;
                    case "7_7":
                        ItemIndex = Array.FindIndex(Items.ArmorIDs, x => x == Data[3]);
                        cbInventoryItemType.SelectedIndex = 5;
                        DatabaseID = 5;
                        break;
                    case "9_10":
                        ItemIndex = Array.FindIndex(Items.ShieldIDs, x => x == Data[3]);
                        cbInventoryItemType.SelectedIndex = 6;
                        DatabaseID = 6;
                        break;
                    case "10_12":
                        ItemIndex = Array.FindIndex(Items.WeaponIDs, x => x == Data[3]);
                        cbInventoryItemType.SelectedIndex = 7;
                        DatabaseID = 7;
                        break;
                    case "11_11":
                        ItemIndex = Array.FindIndex(Items.CapeIDs, x => x == Data[3]);
                        cbInventoryItemType.SelectedIndex = 8;
                        DatabaseID = 8;
                        break;
                }
                LoadItemDatabase(DatabaseID);
                cbInventoryItem.SelectedIndex = ItemIndex;
                cbInventoryEnchantment2.SelectedIndex = Array.FindIndex(Items.ItemSecondaryEnchantmentIDs, x => x == Data[4]);
                txtInventoryAlignment.Text = Data[5];
            }

            DisableItemSave = false;
        }
        private void LoadItemDatabase(int Type) {
            cbInventoryItem.SelectedIndex = -1;
            cbInventoryItem.Items.Clear();
            switch (Type) {
                case 0: // Helmets
                    cbInventoryItem.Items.AddRange(Items.HelmetNames);
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5: // Armors
                    cbInventoryItem.Items.AddRange(Items.ArmorNames);
                    break;
                case 6: // Shields
                    cbInventoryItem.Items.AddRange(Items.ShieldNames);
                    break;
                case 7: // Weapons
                    cbInventoryItem.Items.AddRange(Items.WeaponNames);
                    break;
                case 8: // Capes
                    cbInventoryItem.Items.AddRange(Items.CapeNames);
                    break;
            }
        }
        private void SaveItem() {
            // Saves the items when changing them in the editor
            // Does not save them if an item is being loaded, and the comboboxes get changed from loading.

            if (ItemLoaded > -1 && !DisableItemSave) {
                switch (ItemLoaded) {
                    case 1:
                        Loaded.Inventory1EquippedHelmet = Loaded.GenerateInventoryItem();
                        break;
                    case 2:
                        Loaded.Inventory2EquippedChest = Loaded.GenerateInventoryItem();
                        break;
                    case 3:
                        Loaded.Inventory3EquippedShoulders = Loaded.GenerateInventoryItem();
                        break;
                    case 4:
                        Loaded.Inventory4EquippedArms = Loaded.GenerateInventoryItem();
                        break;
                    case 6:
                        Loaded.Inventory6EquippedLegs = Loaded.GenerateInventoryItem();
                        break;
                    case 7:
                        Loaded.Inventory7EquippedFeet = Loaded.GenerateInventoryItem();
                        break;
                    case 9:
                        Loaded.Inventory9EquippedOffHand = Loaded.GenerateInventoryItem();
                        break;
                    case 10:
                        Loaded.Inventory10EquippedPrimaryWeapon = Loaded.GenerateInventoryItem();
                        break;
                    case 11:
                        Loaded.Inventory11EquippedCape = Loaded.GenerateInventoryItem();
                        break;
                    case 13:
                        Loaded.Inventory13Backpack1 = Loaded.GenerateInventoryItem();
                        break;
                    case 14:
                        Loaded.Inventory14Backpack2 = Loaded.GenerateInventoryItem();
                        break;
                    case 15:
                        Loaded.Inventory15Backpack3 = Loaded.GenerateInventoryItem();
                        break;
                    case 16:
                        Loaded.Inventory16Backpack4 = Loaded.GenerateInventoryItem();
                        break;
                    case 17:
                        Loaded.Inventory17Backpack5 = Loaded.GenerateInventoryItem();
                        break;
                    case 18:
                        Loaded.Inventory18Backpack6 = Loaded.GenerateInventoryItem();
                        break;
                    case 19:
                        Loaded.Inventory19Backpack7 = Loaded.GenerateInventoryItem();
                        break;
                    case 20:
                        Loaded.Inventory20Backpack8 = Loaded.GenerateInventoryItem();
                        break;
                    case 21:
                        Loaded.Inventory21Backpack9 = Loaded.GenerateInventoryItem();
                        break;
                    case 22:
                        Loaded.Inventory22Backpack10 = Loaded.GenerateInventoryItem();
                        break;
                    case 23:
                        Loaded.Inventory23Backpack11 = Loaded.GenerateInventoryItem();
                        break;
                    case 24:
                        Loaded.Inventory24Backpack12 = Loaded.GenerateInventoryItem();
                        break;
                    case 25:
                        Loaded.Inventory25Backpack13 = Loaded.GenerateInventoryItem();
                        break;
                    case 26:
                        Loaded.Inventory26Backpack14 = Loaded.GenerateInventoryItem();
                        break;
                    case 27:
                        Loaded.Inventory27Backpack15 = Loaded.GenerateInventoryItem();
                        break;
                    case 28:
                        Loaded.Inventory28Backpack16 = Loaded.GenerateInventoryItem();
                        break;
                    case 29:
                        Loaded.Inventory29Backpack17 = Loaded.GenerateInventoryItem();
                        break;
                    case 30:
                        Loaded.Inventory30Backpack18 = Loaded.GenerateInventoryItem();
                        break;
                    case 31:
                        Loaded.Date = Loaded.GenerateInventoryItem();
                        break;
                    case 32:
                        Loaded.Foozle = Loaded.GenerateInventoryItem();
                        break;
                }
            }
        }
        private void GladiatorParse(bool Generate = false) {
            if (Generate) {
                SaveItem();
                string NewGladiator = Loaded.GenerateData();
                if (FileLoaded) {
                    GladiatorsList[cbGladiator.SelectedIndex] = NewGladiator;
                    cbGladiator.Items[cbGladiator.SelectedIndex] = Loaded.Name;
                    //FileString.Replace(Loaded.LoadedGladiator, NewGladiator);
                    Loaded.LoadedGladiator = NewGladiator;
                }
                else {
                    cbGladiator.Text = NewGladiator;
                }
            }
            else {
                if (!string.IsNullOrEmpty(cbGladiator.Text)) {
                    Loaded = new Gladiator();
                    Loaded.AllArraysNames = Items.HelmetNames.Concat(Items.ArmorNames).Concat(Items.CapeNames).Concat(Items.ShieldNames).Concat(Items.WeaponNames).ToArray();
                    Loaded.AllArraysIDs = Items.HelmetIDs.Concat(Items.ArmorIDs).Concat(Items.CapeIDs).Concat(Items.ShieldIDs).Concat(Items.WeaponIDs).ToArray();

                    string Gladiator = null;
                    if (FileLoaded) {
                        switch (FileType) {
                            case 0:
                                Gladiator = GladiatorsList[cbGladiator.SelectedIndex];
                                break;
                            case 1:
                                break;
                        }
                    }
                    else {
                        Gladiator = cbGladiator.Text;
                    }

                    if (Loaded.LoadGladiator(Gladiator)) {
                        DisableItemSave = true;
                        txtGladiatorID.Text = Loaded.GladiatorID;
                        txtUserID.Text = Loaded.UserID;
                        txtName.Text = Loaded.Name;
                        txtLevel.Text = Loaded.Level;
                        txtWins.Text = Loaded.Wins;
                        txtLosses.Text = Loaded.Losses;
                        txtTauntQuote.Text = Loaded.TauntQuote;
                        txtVictoryQuote.Text = Loaded.VictoryQuote;

                        txtWarfareSwordMastery.Text = Loaded.WarfareSwordMastery;
                        txtWarfareMaceMastery.Text = Loaded.WarfareMaceMastery;
                        txtWarfareAxeMastery.Text = Loaded.WarfareAxeMastery;
                        txtWarfarePolearmMastery.Text = Loaded.WarfarePolearmMastery;
                        txtWarfareRangedMastery.Text = Loaded.WarfareRangedMastery;
                        txtWarfare2HandedMastery.Text = Loaded.WarfareTwoHandedMastery;
                        txtWarfareDualWielding.Text = Loaded.WarfareDualWielding;
                        txtWarfareGunMastery.Text = Loaded.WarfareGunMastery;
                        txtWarfareCriticalMastery.Text = Loaded.WarfareCriticalMastery;
                        txtWarfareWhirlwind.Text = Loaded.WarfareWhirlwind;

                        txtArcaneMagickaRegeneration.Text = Loaded.ArcaneMagickaRegeneration;
                        txtArcaneArcaneLore.Text = Loaded.ArcaneArcaneLore;
                        txtArcaneFireMastery.Text = Loaded.ArcaneFireMastery;
                        txtArcaneLightningMastery.Text = Loaded.ArcaneLightningMastery;
                        txtArcaneFrostMastery.Text = Loaded.ArcaneFrostMastery;
                        txtArcaneAbjurationMastery.Text = Loaded.ArcaneAbjurationMastery;
                        txtArcaneIllusionMastery.Text = Loaded.ArcaneIllusionMastery;
                        txtArcanePoisonMastery.Text = Loaded.ArcanePoisonMastery;
                        txtArcaneNecromancyMastery.Text = Loaded.ArcaneNecromancyMastery;
                        txtArcaneEssence.Text = Loaded.ArcaneEssence;

                        txtTheatricsMercantile.Text = Loaded.TheatricsMercantile;
                        txtTheatricsForkedTongue.Text = Loaded.TheatricsForkedTongue;
                        txtTheatricsGuitarMastery.Text = Loaded.TheatricsGuitarMastery;
                        txtTheatricsArchaeology.Text = Loaded.TheatricsArchaeology;
                        txtTheatricsDistortion.Text = Loaded.TheatricsDistortion;
                        txtTheatricsAmplify.Text = Loaded.TheatricsAmplify;
                        txtTheatricsSerenity.Text = Loaded.TheatricsSerenity;
                        txtTheatricsShred.Text = Loaded.TheatricsShred;
                        txtTheatricsVirtuoso.Text = Loaded.TheatricsVirtuoso;
                        txtTheatricsPeoplesChampion.Text = Loaded.TheatricsPeoplesChampion;

                        txtSurvivalAcrobatics.Text = Loaded.SurvivalAcrobatics;
                        txtSurvivalDodgeMastery.Text = Loaded.SurvivalDodgeMastery;
                        txtSurvivalConviction.Text = Loaded.SurvivalConviction;
                        txtSurvivalParryingMastery.Text = Loaded.SurvivalParryingMastery;
                        txtSurvivalElementalResistance.Text = Loaded.SurvivalElementalResistance;
                        txtSurvivalShieldMastery.Text = Loaded.SurvivalShieldMastery;
                        txtSurvivalImmovable.Text = Loaded.SurvivalImmovable;
                        txtSurvivalRobustConstitution.Text = Loaded.SurvivalRobustConstitution;
                        txtSurvivalArmourer.Text = Loaded.SurvivalArmourer;
                        txtSurvivalJuggernaut.Text = Loaded.SurvivalJuggernaut;

                        int ParsedInt = -1;
                        int.TryParse(Loaded.DNASkinColor, out ParsedInt);
                        cbDNASkinColor.SelectedIndex = ParsedInt - 1;
                        ParsedInt = -1;
                        int.TryParse(Loaded.DNAHairColor, out ParsedInt);
                        cbDNAHairColor.SelectedIndex = ParsedInt - 1;
                        ParsedInt = -1;
                        int.TryParse(Loaded.DNAHairType, out ParsedInt);
                        cbDNAHairType.SelectedIndex = ParsedInt - 1;
                        ParsedInt = -1;
                        int.TryParse(Loaded.DNABeardType, out ParsedInt);
                        cbDNABeardType.SelectedIndex = ParsedInt - 1;
                        ParsedInt = -1;
                        txtDNAHeight.Text = Loaded.DNAHeight;
                        txtDNAWeight.Text = Loaded.DNAWeight;
                        int.TryParse(Loaded.DNAEarsType, out ParsedInt);
                        cbDNAEarsType.SelectedIndex = ParsedInt - 1;
                        ParsedInt = -1;
                        int.TryParse(Loaded.DNAEars2Type, out ParsedInt);
                        cbDNAEars2Type.SelectedIndex = ParsedInt - 1;
                        ParsedInt = -1;
                        int.TryParse(Loaded.DNAEyesType, out ParsedInt);
                        switch (ParsedInt) {
                            case 1:
                            case 2:
                            case 3:
                                cbDNAEyesType.SelectedIndex = 0;
                                break;
                            case 4:
                                cbDNAEyesType.SelectedIndex = 1;
                                break;
                            case 5:
                                cbDNAEyesType.SelectedIndex = 2;
                                break;
                            case 6:
                                cbDNAEyesType.SelectedIndex = 3;
                                break;
                            case 7:
                                cbDNAEyesType.SelectedIndex = 4;
                                break;
                            case 8:
                                cbDNAEyesType.SelectedIndex = 5;
                                break;
                            case 9:
                                cbDNAEyesType.SelectedIndex = 6;
                                break;
                            case 10:
                                cbDNAEyesType.SelectedIndex = 7;
                                break;
                            default:
                                cbDNAEyesType.SelectedIndex = 8;
                                break;
                        }
                        ParsedInt = -1;
                        int.TryParse(Loaded.DNAMouthType, out ParsedInt);
                        switch (ParsedInt) {
                            case 1:
                            case 2:
                            case 3:
                                cbDNAMouthType.SelectedIndex = 0;
                                break;
                            case 4:
                                cbDNAMouthType.SelectedIndex = 1;
                                break;
                            case 5:
                                cbDNAMouthType.SelectedIndex = 2;
                                break;
                            case 6:
                                cbDNAMouthType.SelectedIndex = 3;
                                break;
                            case 7:
                                cbDNAMouthType.SelectedIndex = 4;
                                break;
                            case 8:
                                cbDNAMouthType.SelectedIndex = 5;
                                break;
                            case 9:
                                cbDNAMouthType.SelectedIndex = 6;
                                break;
                            case 10:
                                cbDNAMouthType.SelectedIndex = 7;
                                break;
                            default:
                                cbDNAMouthType.SelectedIndex = 8;
                                break;
                        }
                        ParsedInt = -1;
                        int.TryParse(Loaded.DNABodyType, out ParsedInt);
                        switch (ParsedInt) {
                            case 1:
                            case 2:
                            case 3:
                                cbDNABodyType.SelectedIndex = 0;
                                break;
                            case 4:
                                cbDNABodyType.SelectedIndex = 1;
                                break;
                            case 5:
                                cbDNABodyType.SelectedIndex = 2;
                                break;
                            case 6:
                                cbDNABodyType.SelectedIndex = 3;
                                break;
                            case 7:
                                cbDNABodyType.SelectedIndex = 4;
                                break;
                            case 8:
                                cbDNABodyType.SelectedIndex = 5;
                                break;
                            case 9:
                                cbDNABodyType.SelectedIndex = 6;
                                break;
                            case 10:
                                cbDNABodyType.SelectedIndex = 7;
                                break;
                            default:
                                cbDNABodyType.SelectedIndex = 8;
                                break;
                        }
                        ParsedInt = -1;
                        txtDNAAlignment.Text = Loaded.DNAAlignment;

                        txtAttribsStrength.Text = Loaded.AttribStrength;
                        txtAttribsVitality.Text = Loaded.AttribVitality;
                        txtAttribsCharisma.Text = Loaded.AttribCharisma;
                        txtAttribsIntellect.Text = Loaded.AttribIntellect;
                        txtAttribsAgility.Text = Loaded.AttribAgility;

                        txtExperience.Text = Loaded.Stats3Exp;
                        txtRequiredExperience.Text = Loaded.Stats4TotalExpRequired;
                        txtWinStreak.Text = Loaded.Stats8WinStreak;

                        cbInventoryItemType.SelectedIndex = -1;
                        cbInventoryEnchantment1.SelectedIndex = -1;
                        cbInventoryItem.SelectedIndex = -1;
                        cbInventoryEnchantment2.SelectedIndex = -1;
                        txtInventoryAlignment.Clear();

                        txtGold.Text = Loaded.Gold;
                        if (Loaded.MaxItems == "30") {
                            rb18InventorySize.Checked = true;
                            rbInventorySlot19.Enabled = false;
                            rbInventorySlot20.Enabled = false;
                        }
                        else {
                            rb20InventorySize.Checked = true;
                            rbInventorySlot19.Enabled = true;
                            rbInventorySlot20.Enabled = true;
                        }

                        int.TryParse(Loaded.NextBoss, out ParsedInt);
                        cbNextBoss.SelectedIndex = ParsedInt - 1;

                        tabCharacter.Enabled = true;
                        btnSaveGladiator.Enabled = true;
                        DisableItemSave = false;
                    }
                }
            }
        }

        private void cbGladiator_SelectedIndexChanged(object sender, EventArgs e) {
            if (FileLoaded) {
                GladiatorParse();
            }
        }
        private void btnParse_Click(object sender, EventArgs e) {
            GladiatorParse(false);
        }
        private void btnSaveGladiator_Click(object sender, EventArgs e) {
            GladiatorParse(true);
        }

        private void mDebugSplit_Click(object sender, EventArgs e) {
            if (Clipboard.ContainsText()) {
                string Data = Clipboard.GetText();
                Clipboard.SetText(string.Join("\n", Data.Split(',')));
            }
        }
        private void mDebugJoin_Click(object sender, EventArgs e) {
            if (Clipboard.ContainsText()) {
                string Data = Clipboard.GetText();
                Clipboard.SetText(Data.Replace("\r", "").Replace("\n", ","));
            }
        }

        #region General Events
        private void txtNumberOnly_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {
                e.Handled = true;
            }
        }
        private void txtNumberOnlyWithDecimal_KeyPress(object sender, KeyPressEventArgs e) {
            TextBox textBox = sender as TextBox;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.' || e.KeyChar == '.' && textBox.Text.Contains('.')) {
                e.Handled = true;
            }
        }
        private void txtNumberOnlyWithNegatives_KeyPress(object sender, KeyPressEventArgs e) {
            TextBox textBox = sender as TextBox;

            if (e.KeyChar == '-' && !textBox.Text.StartsWith("-")) {
                int SelectionStart = textBox.SelectionStart + 1;
                int SelectionLength = textBox.SelectionLength;
                textBox.Text = "-" + textBox.Text;
                textBox.SelectionStart = SelectionStart;
                textBox.SelectionLength = SelectionLength;
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {
                e.Handled = true;
            }
        }
        #endregion

        #region Gladiator Info
        private void txtName_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == ',') {
                e.Handled = true;
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e) {
            Loaded.Name = txtName.Text;
        }

        private void txtTauntQuote_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == ',') {
                e.Handled = true;
            }
        }
        private void txtTauntQuote_TextChanged(object sender, EventArgs e) {
            Loaded.TauntQuote = txtTauntQuote.Text;
        }

        private void txtVictoryQuote_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == ',') {
                e.Handled = true;
            }
        }
        private void txtVictoryQuote_TextChanged(object sender, EventArgs e) {
            Loaded.VictoryQuote = txtVictoryQuote.Text;
        }

        private void txtAttribsStrength_TextChanged(object sender, EventArgs e) {
            Loaded.AttribStrength = txtAttribsStrength.Text;
        }
        private void txtAttribsVitality_TextChanged(object sender, EventArgs e) {
            Loaded.AttribVitality = txtAttribsVitality.Text;
        }
        private void txtAttribsCharisma_TextChanged(object sender, EventArgs e) {
            Loaded.AttribCharisma = txtAttribsCharisma.Text;
        }
        private void txtAttribsIntellect_TextChanged(object sender, EventArgs e) {
            Loaded.AttribIntellect = txtAttribsIntellect.Text;
        }
        private void txtAttribsAgility_TextChanged(object sender, EventArgs e) {
            Loaded.AttribAgility = txtAttribsAgility.Text;
        }

        private void txtGold_TextChanged(object sender, EventArgs e) {
            Loaded.Gold = txtGold.Text;
            Loaded.Stats5Gold = txtGold.Text;
        }

        private void txtWins_TextChanged(object sender, EventArgs e) {
            Loaded.Wins = txtWins.Text;
            Loaded.Stats6Wins = txtWins.Text;
        }

        private void txtLosses_TextChanged(object sender, EventArgs e) {
            Loaded.Losses = txtLosses.Text;
            Loaded.Stats7Losses = txtLosses.Text;
        }

        private void txtExperience_TextChanged(object sender, EventArgs e) {
            Loaded.Stats3Exp = txtExperience.Text;
        }

        private void txtRequiredExperience_TextChanged(object sender, EventArgs e) {
            Loaded.Stats4TotalExpRequired = txtRequiredExperience.Text;
        }

        private void txtWinStreak_TextChanged(object sender, EventArgs e) {
            Loaded.Stats8WinStreak = txtWinStreak.Text;
        }

        private void txtGladiatorID_TextChanged(object sender, EventArgs e) {
            Loaded.GladiatorID = txtGladiatorID.Text;
        }

        private void txtLevel_TextChanged(object sender, EventArgs e) {
            Loaded.Level = txtLevel.Text;
        }

        private void cbNextBoss_SelectedIndexChanged(object sender, EventArgs e) {
            Loaded.NextBoss = (cbNextBoss.SelectedIndex + 1).ToString();
        }
        #endregion

        #region Inventory
        private void rbInventoryHelmet_CheckedChanged(object sender, EventArgs e) {
            if (rbInventoryHelmet.Checked) {
                LoadItem(Loaded.Inventory1EquippedHelmet);
                ItemLoaded = 1;
                cbInventoryItemType.Enabled = false;
            }
        }
        private void rbInventoryChest_CheckedChanged(object sender, EventArgs e) {
            if (rbInventoryChest.Checked) {
                LoadItem(Loaded.Inventory2EquippedChest);
                ItemLoaded = 2;
                cbInventoryItemType.Enabled = false;
            }
        }
        private void rbInventoryShoulders_CheckedChanged(object sender, EventArgs e) {
            if (rbInventoryShoulders.Checked) {
                LoadItem(Loaded.Inventory3EquippedShoulders);
                ItemLoaded = 3;
                cbInventoryItemType.Enabled = false;
            }
        }
        private void rbInventoryArms_CheckedChanged(object sender, EventArgs e) {
            if (rbInventoryArms.Checked) {
                LoadItem(Loaded.Inventory4EquippedArms);
                ItemLoaded = 4;
                cbInventoryItemType.Enabled = false;
            }
        }
        private void rbInventoryLegs_CheckedChanged(object sender, EventArgs e) {
            if (rbInventoryLegs.Checked) {
                LoadItem(Loaded.Inventory6EquippedLegs);
                ItemLoaded = 6;
                cbInventoryItemType.Enabled = false;
            }
        }
        private void rbInventoryFeet_CheckedChanged(object sender, EventArgs e) {
            if (rbInventoryFeet.Checked) {
                LoadItem(Loaded.Inventory7EquippedFeet);
                ItemLoaded = 7;
                cbInventoryItemType.Enabled = false;
            }
        }
        private void rbInventoryOffHand_CheckedChanged(object sender, EventArgs e) {
            if (rbInventoryOffHand.Checked) {
                LoadItem(Loaded.Inventory9EquippedOffHand);
                ItemLoaded = 9;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventoryWeapon_CheckedChanged(object sender, EventArgs e) {
            if (rbInventoryWeapon.Checked) {
                LoadItem(Loaded.Inventory10EquippedPrimaryWeapon);
                ItemLoaded = 10;
                cbInventoryItemType.Enabled = false;
            }
        }
        private void rbInventoryCape_CheckedChanged(object sender, EventArgs e) {
            if (rbInventoryCape.Checked) {
                LoadItem(Loaded.Inventory11EquippedCape);
                ItemLoaded = 11;
                cbInventoryItemType.Enabled = false;
            }
        }

        private void rbInventorySlot1_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot1.Checked) {
                LoadItem(Loaded.Inventory13Backpack1);
                ItemLoaded = 13;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot2_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot2.Checked) {
                LoadItem(Loaded.Inventory14Backpack2);
                ItemLoaded = 14;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot3_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot3.Checked) {
                LoadItem(Loaded.Inventory15Backpack3);
                ItemLoaded = 15;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot4_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot4.Checked) {
                LoadItem(Loaded.Inventory16Backpack4);
                ItemLoaded = 16;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot5_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot5.Checked) {
                LoadItem(Loaded.Inventory17Backpack5);
                ItemLoaded = 17;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot6_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot6.Checked) {
                LoadItem(Loaded.Inventory18Backpack6);
                ItemLoaded = 18;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot7_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot7.Checked) {
                LoadItem(Loaded.Inventory19Backpack7);
                ItemLoaded = 19;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot8_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot8.Checked) {
                LoadItem(Loaded.Inventory20Backpack8);
                ItemLoaded = 20;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot9_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot9.Checked) {
                LoadItem(Loaded.Inventory21Backpack9);
                ItemLoaded = 21;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot10_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot10.Checked) {
                LoadItem(Loaded.Inventory22Backpack10);
                ItemLoaded = 22;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot11_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot11.Checked) {
                LoadItem(Loaded.Inventory23Backpack11);
                ItemLoaded = 23;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot12_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot12.Checked) {
                LoadItem(Loaded.Inventory24Backpack12);
                ItemLoaded = 24;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot13_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot13.Checked) {
                LoadItem(Loaded.Inventory25Backpack13);
                ItemLoaded = 25;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot14_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot14.Checked) {
                LoadItem(Loaded.Inventory26Backpack14);
                ItemLoaded = 26;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot15_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot15.Checked) {
                LoadItem(Loaded.Inventory27Backpack15);
                ItemLoaded = 27;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot16_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot16.Checked) {
                LoadItem(Loaded.Inventory28Backpack16);
                ItemLoaded = 28;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot17_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot17.Checked) {
                LoadItem(Loaded.Inventory29Backpack17);
                ItemLoaded = 29;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot18_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot18.Checked) {
                LoadItem(Loaded.Inventory30Backpack18);
                ItemLoaded = 30;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot19_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot19.Checked && rb20InventorySize.Checked && Loaded.MaxItems == "32") {
                LoadItem(Loaded.Date);
                ItemLoaded = 31;
                cbInventoryItemType.Enabled = true;
            }
        }
        private void rbInventorySlot20_CheckedChanged(object sender, EventArgs e) {
            if (rbInventorySlot20.Checked && rb20InventorySize.Checked && Loaded.MaxItems == "32") {
                LoadItem(Loaded.Foozle);
                ItemLoaded = 32;
                cbInventoryItemType.Enabled = true;
            }
        }

        private void cbInventoryItemType_SelectedIndexChanged(object sender, EventArgs e) {
            if (!DisableItemSave) {
                if (rbInventoryOffHand.Checked) {
                    if (cbInventoryItemType.SelectedIndex != 6 && cbInventoryItemType.SelectedIndex != 7) {
                        cbInventoryItemType.SelectedIndex = 6;
                    }
                }
                switch (cbInventoryItemType.SelectedIndex) {
                    case 0:
                        Loaded.LoadedInventoryType = "1_1";
                        LoadItemDatabase(0);
                        break;
                    case 1:
                        Loaded.LoadedInventoryType = "2_2";
                        LoadItemDatabase(1);
                        break;
                    case 2:
                        Loaded.LoadedInventoryType = "3_3";
                        LoadItemDatabase(2);
                        break;
                    case 3:
                        Loaded.LoadedInventoryType = "4_4";
                        LoadItemDatabase(3);
                        break;
                    case 4:
                        Loaded.LoadedInventoryType = "6_6";
                        LoadItemDatabase(4);
                        break;
                    case 5:
                        Loaded.LoadedInventoryType = "7_7";
                        LoadItemDatabase(5);
                        break;
                    case 6:
                        Loaded.LoadedInventoryType = "9_10";
                        LoadItemDatabase(6);
                        break;
                    case 7:
                        Loaded.LoadedInventoryType = "10_12";
                        LoadItemDatabase(7);
                        break;
                    case 8:
                        Loaded.LoadedInventoryType = "11_11";
                        LoadItemDatabase(8);
                        break;
                }
            }
        }
        private void cbInventoryEnchantment1_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbInventoryEnchantment1.SelectedIndex > -1) {
                justthetip.SetToolTip(cbInventoryEnchantment1, cbInventoryEnchantment1.GetItemText(cbInventoryEnchantment1.SelectedItem));
                if (!DisableItemSave) {
                    Loaded.LoadedInventoryEnchantment1 = Items.ItemPrimaryEnchantmentIDs[cbInventoryEnchantment1.SelectedIndex];
                }
            }
        }
        private void cbInventoryItem_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbInventoryItem.SelectedIndex > -1) {
                justthetip.SetToolTip(cbInventoryItem, cbInventoryItem.GetItemText(cbInventoryItem.SelectedItem));
                if (!DisableItemSave) {
                    switch (cbInventoryItemType.SelectedIndex) {
                        case 0:
                            Loaded.LoadedInventoryItem = Items.HelmetIDs[cbInventoryItem.SelectedIndex];
                            break;
                        case 1:
                            Loaded.LoadedInventoryItem = Items.ArmorIDs[cbInventoryItem.SelectedIndex];
                            break;
                        case 2:
                            Loaded.LoadedInventoryItem = Items.ArmorIDs[cbInventoryItem.SelectedIndex];
                            break;
                        case 3:
                            Loaded.LoadedInventoryItem = Items.ArmorIDs[cbInventoryItem.SelectedIndex];
                            break;
                        case 4:
                            Loaded.LoadedInventoryItem = Items.ArmorIDs[cbInventoryItem.SelectedIndex];
                            break;
                        case 5:
                            Loaded.LoadedInventoryItem = Items.ArmorIDs[cbInventoryItem.SelectedIndex];
                            break;
                        case 6:
                            Loaded.LoadedInventoryItem = Items.ShieldIDs[cbInventoryItem.SelectedIndex];
                            break;
                        case 7:
                            Loaded.LoadedInventoryItem = Items.WeaponIDs[cbInventoryItem.SelectedIndex];
                            break;
                        case 8:
                            Loaded.LoadedInventoryItem = Items.CapeIDs[cbInventoryItem.SelectedIndex];
                            break;
                    }
                }
            }
        }
        private void cbInventoryEnchantment2_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbInventoryEnchantment2.SelectedIndex > -1) {
                justthetip.SetToolTip(cbInventoryEnchantment2, cbInventoryEnchantment2.GetItemText(cbInventoryEnchantment2.SelectedItem));
                if (!DisableItemSave) {
                    Loaded.LoadedInventoryEnchantment2 = Items.ItemSecondaryEnchantmentIDs[cbInventoryEnchantment2.SelectedIndex];

                }
            }
        }
        private void txtInventoryAlignment_TextChanged(object sender, EventArgs e) {
            if (!DisableItemSave) {
                if (txtInventoryAlignment.Text.Length > 0) {
                    Loaded.LoadedInventoryAlignment = txtInventoryAlignment.Text;
                }
                else {
                    Loaded.LoadedInventoryAlignment = "0";
                }

            }
        }
        #endregion

        #region Gladiator Appearance
        private void cbDNABodyType_SelectedIndexChanged(object sender, EventArgs e) {
            int Index = cbDNABodyType.SelectedIndex + 3;
            if (Index == 3) {
                Index = 1;
            }
            Loaded.DNABodyType = Index.ToString();
        }
        private void cbDNASkinColor_SelectedIndexChanged(object sender, EventArgs e) {
            Loaded.DNASkinColor = (cbDNASkinColor.SelectedIndex + 1).ToString();
        }
        private void cbDNAHairColor_SelectedIndexChanged(object sender, EventArgs e) {
            Loaded.DNAHairColor = (cbDNAHairColor.SelectedIndex + 1).ToString();
        }
        private void txtDNAAlignment_TextChanged(object sender, EventArgs e) {
            Loaded.DNAAlignment = txtDNAAlignment.Text;
        }
        private void cbDNAHairType_SelectedIndexChanged(object sender, EventArgs e) {
            Loaded.DNAHairType = (cbDNAHairType.SelectedIndex + 1).ToString();
        }
        private void cbDNABeardType_SelectedIndexChanged(object sender, EventArgs e) {
            Loaded.DNABeardType = (cbDNABeardType.SelectedIndex + 1).ToString();
        }
        private void txtDNAHeight_TextChanged(object sender, EventArgs e) {
            Loaded.DNAHeight = txtDNAHeight.Text;
        }
        private void txtDNAWeight_TextChanged(object sender, EventArgs e) {
            Loaded.DNAWeight = txtDNAWeight.Text;
        }
        private void cbDNAEarsType_SelectedIndexChanged(object sender, EventArgs e) {
            Loaded.DNAEarsType = (cbDNAEarsType.SelectedIndex + 1).ToString();
        }
        private void cbDNAEars2Type_SelectedIndexChanged(object sender, EventArgs e) {
            Loaded.DNAEars2Type = (cbDNAEars2Type.SelectedIndex + 1).ToString();
        }
        private void cbDNAEyesType_SelectedIndexChanged(object sender, EventArgs e) {
            int Index = cbDNAEyesType.SelectedIndex + 3;
            if (Index == 3) {
                Index = 1;
            }
            Loaded.DNAEyesType = Index.ToString();
        }
        private void cbDNAMouthType_SelectedIndexChanged(object sender, EventArgs e) {
            int Index = cbDNAMouthType.SelectedIndex + 3;
            if (Index == 3) {
                Index = 1;
            }
            Loaded.DNAMouthType = Index.ToString();
        }
        #endregion

        #region Advanced
        private void btnSetArenaChampion_Click(object sender, EventArgs e) {
            if (cbChampionList.SelectedIndex > -1) {
                if (Loaded.SetGladiatorAsChampion(cbChampionList.SelectedIndex)) {
                    txtName.Text = Loaded.Name;
                    txtLevel.Text = Loaded.Level;
                    txtTauntQuote.Text = Loaded.TauntQuote;
                    txtVictoryQuote.Text = Loaded.VictoryQuote;

                    int ParsedInt = -1;
                    int.TryParse(Loaded.DNASkinColor, out ParsedInt);
                    cbDNASkinColor.SelectedIndex = ParsedInt - 1;
                    ParsedInt = -1;
                    int.TryParse(Loaded.DNAHairColor, out ParsedInt);
                    cbDNAHairColor.SelectedIndex = ParsedInt - 1;
                    ParsedInt = -1;
                    int.TryParse(Loaded.DNAHairType, out ParsedInt);
                    cbDNAHairType.SelectedIndex = ParsedInt - 1;
                    ParsedInt = -1;
                    int.TryParse(Loaded.DNABeardType, out ParsedInt);
                    cbDNABeardType.SelectedIndex = ParsedInt - 1;
                    ParsedInt = -1;
                    txtDNAHeight.Text = Loaded.DNAHeight;
                    txtDNAWeight.Text = Loaded.DNAWeight;
                    int.TryParse(Loaded.DNAEarsType, out ParsedInt);
                    cbDNAEarsType.SelectedIndex = ParsedInt - 1;
                    ParsedInt = -1;
                    int.TryParse(Loaded.DNAEars2Type, out ParsedInt);
                    cbDNAEars2Type.SelectedIndex = ParsedInt - 1;
                    ParsedInt = -1;
                    int.TryParse(Loaded.DNAEyesType, out ParsedInt);
                    switch (ParsedInt) {
                        case 1:
                        case 2:
                        case 3:
                            cbDNAEyesType.SelectedIndex = 0;
                            break;
                        case 4:
                            cbDNAEyesType.SelectedIndex = 1;
                            break;
                        case 5:
                            cbDNAEyesType.SelectedIndex = 2;
                            break;
                        case 6:
                            cbDNAEyesType.SelectedIndex = 3;
                            break;
                        case 7:
                            cbDNAEyesType.SelectedIndex = 4;
                            break;
                        case 8:
                            cbDNAEyesType.SelectedIndex = 5;
                            break;
                        case 9:
                            cbDNAEyesType.SelectedIndex = 6;
                            break;
                        case 10:
                            cbDNAEyesType.SelectedIndex = 7;
                            break;
                        default:
                            cbDNAEyesType.SelectedIndex = 8;
                            break;
                    }
                    ParsedInt = -1;
                    int.TryParse(Loaded.DNAMouthType, out ParsedInt);
                    switch (ParsedInt) {
                        case 1:
                        case 2:
                        case 3:
                            cbDNAMouthType.SelectedIndex = 0;
                            break;
                        case 4:
                            cbDNAMouthType.SelectedIndex = 1;
                            break;
                        case 5:
                            cbDNAMouthType.SelectedIndex = 2;
                            break;
                        case 6:
                            cbDNAMouthType.SelectedIndex = 3;
                            break;
                        case 7:
                            cbDNAMouthType.SelectedIndex = 4;
                            break;
                        case 8:
                            cbDNAMouthType.SelectedIndex = 5;
                            break;
                        case 9:
                            cbDNAMouthType.SelectedIndex = 6;
                            break;
                        case 10:
                            cbDNAMouthType.SelectedIndex = 7;
                            break;
                        default:
                            cbDNAMouthType.SelectedIndex = 8;
                            break;
                    }
                    ParsedInt = -1;
                    int.TryParse(Loaded.DNABodyType, out ParsedInt);
                    switch (ParsedInt) {
                        case 1:
                        case 2:
                        case 3:
                            cbDNABodyType.SelectedIndex = 0;
                            break;
                        case 4:
                            cbDNABodyType.SelectedIndex = 1;
                            break;
                        case 5:
                            cbDNABodyType.SelectedIndex = 2;
                            break;
                        case 6:
                            cbDNABodyType.SelectedIndex = 3;
                            break;
                        case 7:
                            cbDNABodyType.SelectedIndex = 4;
                            break;
                        case 8:
                            cbDNABodyType.SelectedIndex = 5;
                            break;
                        case 9:
                            cbDNABodyType.SelectedIndex = 6;
                            break;
                        case 10:
                            cbDNABodyType.SelectedIndex = 7;
                            break;
                        default:
                            cbDNABodyType.SelectedIndex = 8;
                            break;
                    }
                    ParsedInt = -1;
                    txtDNAAlignment.Text = Loaded.DNAAlignment;
                }
            }
        }
        #endregion

        #region Load from File
        private void mSOLDatabase_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Title = "Opening SOL Database...";
                ofd.Filter = "ss3_data.sol|ss3_data.sol|Flash Shared Object (*.sol)|*.sol";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK) {
                    FileLocation = ofd.FileName;
                    //FileString = File.ReadAllText(ofd.FileName, System.Text.Encoding.Default);
                    FileByte = File.ReadAllBytes(ofd.FileName);
                    //string[] FileLines = FileString.Replace("\r", "").Split('\n');
                    //for (int i = 2; i < FileLines.Length; i++) {
                    //    string Gladiator = FileLines[i].Substring(13, FileLines[i].Length - (43));
                    //    GladiatorsList.Add(Gladiator);
                    //    string[] GladiatorLines = Gladiator.Split(',');
                    //    cbGladiator.Items.Add(GladiatorLines[2]);
                    //}

                    for (int i = 120; i < FileByte.Length; i++) {
                        if (FileByte[i] != 0x2C) {
                            continue;
                        }
                    }






                    cbGladiator.DropDownStyle = ComboBoxStyle.DropDownList;
                    FileLoaded = true;
                    FileType = 0;
                    btnParse.Enabled = false;
                    mCloseCurrentFile.Enabled = true;
                    mSaveFile.Enabled = true;
                }
            }
        }
        private void mSQLiteDatabase_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Title = "Opening SOL Database...";
                ofd.Filter = "char_anim_sync.lib|char_anim_sync.lib|SQLite Database (*.lib)|*.lib";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK) {
                    cbGladiator.DropDownStyle = ComboBoxStyle.DropDownList;
                    FileLoaded = true;
                    FileType = 1;
                    //LoadedFile = File.ReadAllText(ofd.FileName);

                }
            }
        }
        private void mParseFromText_Click(object sender, EventArgs e) {
            GladiatorParse(false);
        }
        private void mBrowseManually_Click(object sender, EventArgs e) {

        }
        private void mCloseCurrentFile_Click(object sender, EventArgs e) {
            FileLoaded = false;
            FileType = -1;
            //FileString = null;
            GladiatorsList.Clear();
            cbGladiator.Items.Clear();
            cbGladiator.DropDownStyle = ComboBoxStyle.DropDown;
            btnParse.Enabled = true;
            btnSaveGladiator.Enabled = false;
        }
        private void mSaveFile_Click(object sender, EventArgs e) {
            if (FileLoaded) {
                switch (FileType) {
                    case 0:
                        if (!File.Exists(FileLocation)) {
                            File.Create(FileLocation).Dispose();
                        }

                        //File.WriteAllText(FileLocation, FileString, System.Text.Encoding.Default);
                        break;
                    case 1:
                        break;
                }
            }
        }
        #endregion

        private void mGenerateDefault_Click(object sender, EventArgs e) {
            cbGladiator.Text = "0,123,Default,1,0,0,Raaaargh!,I cannot be defeated,0_0_0_0_0_0_0_0_0_0,0_0_0_0_0_0_0_0_0_0,0_0_0_0_0_0_0_0_0_0,0_0_0_0_0_0_0_0_0_0,2_6_1_1_50_50_1_1_1_1_1_2_0,1_1_1_1_1,0_0_0_0,10_96_0_238_1000_0_0_0_3,A,1000,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1";
            GladiatorParse();
        }
        private void rb18InventorySize_CheckedChanged(object sender, EventArgs e) {
            Loaded.MaxItems = "30";
            if (rbInventorySlot19.Checked || rbInventorySlot20.Checked) {
                rbInventorySlot19.Checked = false;
                rbInventorySlot20.Checked = false;
                DisableItemSave = true;
                cbInventoryItemType.SelectedIndex = -1;
                cbInventoryEnchantment1.SelectedIndex = -1;
                cbInventoryItem.SelectedIndex = -1;
                cbInventoryEnchantment2.SelectedIndex = -1;
                txtInventoryAlignment.Clear();
                DisableItemSave = false;
            }
            rbInventorySlot19.Enabled = false;
            rbInventorySlot20.Enabled = false;
        }

        private void rb20InventorySize_CheckedChanged(object sender, EventArgs e) {
            Loaded.MaxItems = "32";
            rbInventorySlot19.Enabled = true;
            rbInventorySlot20.Enabled = true;
        }

        private void mAbout_Click(object sender, EventArgs e) {
            MessageBox.Show("Gladiator editor v1.0, by murrty :)");
        }

        private void mGithub_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/murrty/swords-and-sandals-3-gladiator-editor");
        }


        #region Skill Trees

        #endregion

        #region Advanced
        #endregion
    }
}
