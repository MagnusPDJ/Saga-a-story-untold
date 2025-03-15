using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public Player currentPlayer;
    public TextMeshProUGUI displayName;
    public TextMeshProUGUI displayClass;

    private void Update() {
        if (displayName != null) {
            if (displayName.IsActive()) {
                displayName.text = currentPlayer.CharacterInformation.playerName;
            }
        }
        if (displayClass != null) {
            if (displayClass.IsActive()) {
                displayClass.text = currentPlayer.CharacterInformation.playerClass;
            }
        }
    }

    public string GetPlayerName() {
        return currentPlayer.CharacterInformation.playerName;
    }

    public void CalculateTotalStats() {
        currentPlayer.TotalPrimaryAttributes = CalculatePrimaryArmorBonus();
        currentPlayer.BaseSecondaryAttributes = CalculateBaseSecondaryStats();
        currentPlayer.TotalSecondaryAttributes = CalculateSecondaryArmorBonus();
        currentPlayer.DPT = CalculateDPT();
    }

    public SecondaryAttributes CalculateBaseSecondaryStats() {
        return new SecondaryAttributes() {
            MaxHealth = 5 + currentPlayer.TotalPrimaryAttributes.Constitution * 5,
            MaxMana = 5 + currentPlayer.TotalPrimaryAttributes.WillPower * 5,
            Awareness = currentPlayer.TotalPrimaryAttributes.Dexterity,
            ArmorRating = (currentPlayer.TotalPrimaryAttributes.Strength + currentPlayer.TotalPrimaryAttributes.Dexterity) / 2,
            ElementalResistence = currentPlayer.TotalPrimaryAttributes.Intellect
        };
    }
    public PrimaryAttributes CalculatePrimaryArmorBonus() {
        PrimaryAttributes armorBonusValues = new PrimaryAttributes() { Strength = 0, Dexterity = 0, Intellect = 0, Constitution = 0, WillPower = 0 };

        //bool hasHeadArmor = Equipment.TryGetValue(Slot.Headgear, out Item headArmor);
        //bool hasBodyArmor = Equipment.TryGetValue(Slot.Torso, out Item bodyArmor);
        //bool hasLegsArmor = Equipment.TryGetValue(Slot.Legs, out Item legsArmor);
        //bool hasFeetArmor = Equipment.TryGetValue(Slot.Feet, out Item FeetArmor);
        //bool hasArmsArmor = Equipment.TryGetValue(Slot.Bracers, out Item ArmsArmor);
        //bool hasShouldersArmor = Equipment.TryGetValue(Slot.Shoulders, out Item ShouldersArmor);
        //bool hasBeltArmor = Equipment.TryGetValue(Slot.Belt, out Item BeltArmor);
        //bool hasCapeArmor = Equipment.TryGetValue(Slot.Cape, out Item CapeArmor);
        //bool hasGlovesArmor = Equipment.TryGetValue(Slot.Gloves, out Item GlovesArmor);
        //bool hasAmuletArmor = Equipment.TryGetValue(Slot.Amulet, out Item AmuletArmor);
        //bool hasRing1Armor = Equipment.TryGetValue(Slot.SLOT_RING1, out Item Ring1Armor);
        //bool hasRing2Armor = Equipment.TryGetValue(Slot.SLOT_RING2, out Item Ring2Armor);
        //bool hasCrestArmor = Equipment.TryGetValue(Slot.SLOT_CREST, out Item CrestArmor);
        //bool hasTrinketArmor = Equipment.TryGetValue(Slot.SLOT_TRINKET, out Item TrinketArmor);
        //bool hasOffhandArmor = Equipment.TryGetValue(Slot.SLOT_OFFHAND, out Item OffhandArmor);

        //if (hasHeadArmor) {
        //    Armor a = (Armor)headArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasBodyArmor) {
        //    Armor a = (Armor)bodyArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasLegsArmor) {
        //    Armor a = (Armor)legsArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasFeetArmor) {
        //    Armor a = (Armor)FeetArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasArmsArmor) {
        //    Armor a = (Armor)ArmsArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasShouldersArmor) {
        //    Armor a = (Armor)ShouldersArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasBeltArmor) {
        //    Armor a = (Armor)BeltArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasCapeArmor) {
        //    Armor a = (Armor)CapeArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasGlovesArmor) {
        //    Armor a = (Armor)GlovesArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasAmuletArmor) {
        //    Armor a = (Armor)AmuletArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasRing1Armor) {
        //    Armor a = (Armor)Ring1Armor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasRing2Armor) {
        //    Armor a = (Armor)Ring2Armor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasCrestArmor) {
        //    Armor a = (Armor)CrestArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasTrinketArmor) {
        //    Armor a = (Armor)TrinketArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        //if (hasOffhandArmor) {
        //    Armor a = (Armor)OffhandArmor;
        //    armorBonusValues += new PrimaryAttributes() { Strength = a.Attributes.Strength, Dexterity = a.Attributes.Dexterity, Intellect = a.Attributes.Intellect, Constitution = a.Attributes.Constitution, WillPower = a.Attributes.WillPower };
        //}
        return currentPlayer.BasePrimaryAttributes + armorBonusValues;
    }
    public SecondaryAttributes CalculateSecondaryArmorBonus() {
        SecondaryAttributes armorBonusValues = new SecondaryAttributes() { ArmorRating = 0, MaxHealth = 0, MaxMana = 0, Awareness = 0, ElementalResistence = 0 };

        //bool hasHeadArmor = Equipment.TryGetValue(Slot.Headgear, out Item headArmor);
        //bool hasBodyArmor = Equipment.TryGetValue(Slot.Torso, out Item bodyArmor);
        //bool hasLegsArmor = Equipment.TryGetValue(Slot.Legs, out Item legsArmor);
        //bool hasFeetArmor = Equipment.TryGetValue(Slot.Feet, out Item FeetArmor);
        //bool hasArmsArmor = Equipment.TryGetValue(Slot.Bracers, out Item ArmsArmor);
        //bool hasShouldersArmor = Equipment.TryGetValue(Slot.Shoulders, out Item ShouldersArmor);
        //bool hasBeltArmor = Equipment.TryGetValue(Slot.Belt, out Item BeltArmor);
        //bool hasCapeArmor = Equipment.TryGetValue(Slot.Cape, out Item CapeArmor);
        //bool hasGlovesArmor = Equipment.TryGetValue(Slot.Gloves, out Item GlovesArmor);
        //bool hasAmuletArmor = Equipment.TryGetValue(Slot.Amulet, out Item AmuletArmor);
        //bool hasRing1Armor = Equipment.TryGetValue(Slot.SLOT_RING1, out Item Ring1Armor);
        //bool hasRing2Armor = Equipment.TryGetValue(Slot.SLOT_RING2, out Item Ring2Armor);
        //bool hasCrestArmor = Equipment.TryGetValue(Slot.SLOT_CREST, out Item CrestArmor);
        //bool hasTrinketArmor = Equipment.TryGetValue(Slot.SLOT_TRINKET, out Item TrinketArmor);
        //bool hasOffhandArmor = Equipment.TryGetValue(Slot.SLOT_OFFHAND, out Item OffhandArmor);

        //if (hasHeadArmor) {
        //    Armor a = (Armor)headArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasBodyArmor) {
        //    Armor a = (Armor)bodyArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasLegsArmor) {
        //    Armor a = (Armor)legsArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasFeetArmor) {
        //    Armor a = (Armor)FeetArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasArmsArmor) {
        //    Armor a = (Armor)ArmsArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasShouldersArmor) {
        //    Armor a = (Armor)ShouldersArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasBeltArmor) {
        //    Armor a = (Armor)BeltArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasCapeArmor) {
        //    Armor a = (Armor)CapeArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasGlovesArmor) {
        //    Armor a = (Armor)GlovesArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasAmuletArmor) {
        //    Armor a = (Armor)AmuletArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasRing1Armor) {
        //    Armor a = (Armor)Ring1Armor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasRing2Armor) {
        //    Armor a = (Armor)Ring2Armor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasCrestArmor) {
        //    Armor a = (Armor)CrestArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasTrinketArmor) {
        //    Armor a = (Armor)TrinketArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        //if (hasOffhandArmor) {
        //    Armor a = (Armor)OffhandArmor;
        //    armorBonusValues += new SecondaryAttributes() { ArmorRating = a.SecondaryAttributes.ArmorRating, MaxHealth = a.SecondaryAttributes.MaxHealth, MaxMana = a.SecondaryAttributes.MaxMana, Awareness = a.SecondaryAttributes.Awareness, ElementalResistence = a.SecondaryAttributes.ElementalResistence };
        //}
        return currentPlayer.BaseSecondaryAttributes + armorBonusValues;
    }
    public (int, int) CalculateDPT() {
        currentPlayer.TotalPrimaryAttributes = CalculatePrimaryArmorBonus();
        (int, int) weaponDPT = CalculateWeaponDPT();
        if (weaponDPT == (0, 0)) {
            return (1, 1);
        }

        int dmgfromattribute = currentPlayer.TotalPrimaryAttributes.Strength / 3;
        int dmgfromwarrior = currentPlayer.CharacterInformation.level;
        return (weaponDPT.Item1 + dmgfromattribute + dmgfromwarrior, weaponDPT.Item2 + dmgfromattribute + dmgfromwarrior);
    }
    public (int, int) CalculateWeaponDPT() {
        //bool hasWeapon = Equipment.TryGetValue(Slot.Weapon, out Item equippedWeapon);
        //if (hasWeapon) {
        //    Weapon w = (Weapon)equippedWeapon;
        //    return (w.WeaponAttributes.MinDamage, w.WeaponAttributes.MaxDamage);
        //} else {
        return (1, 1);
        //}
    }
}
