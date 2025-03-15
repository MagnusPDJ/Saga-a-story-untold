using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class CharacterInformation {
    [Header("Character Info")]
    public string playerName;
    public string playerClass;
    public int currentHealth;
    public int currentMana;
    public int gold;
    public int exp;
    public int level;
}

[Serializable]
public class PrimaryAttributes {
    [Header("Stats")]
    public int Strength;
    public int Dexterity;
    public int Intellect;
    public int Constitution;
    public int WillPower;
    public static PrimaryAttributes operator +(PrimaryAttributes a, PrimaryAttributes b) => new PrimaryAttributes() {
        Strength = a.Strength + b.Strength,
        Dexterity = a.Dexterity + b.Dexterity,
        Intellect = a.Intellect + b.Intellect,
        Constitution = a.Constitution + b.Constitution,
        WillPower = a.WillPower + b.WillPower
    };
}

[Serializable]
public class SecondaryAttributes {
    [Header("Secondary stats")]
    public int MaxHealth;
    public int MaxMana;
    public int Awareness;
    public int ArmorRating;
    public int ElementalResistence;
    public static SecondaryAttributes operator +(SecondaryAttributes a, SecondaryAttributes b) => new SecondaryAttributes() {
        MaxHealth = a.MaxHealth + b.MaxHealth,
        ArmorRating = a.ArmorRating + b.ArmorRating,
        ElementalResistence = a.ElementalResistence + b.ElementalResistence,
        MaxMana = a.MaxMana + b.MaxMana,
        Awareness = a.Awareness + b.Awareness
    };
}

[Serializable]
public class WeaponAttributes {
    [Header("Attack Power")]
    public int MinDamage;
    public int MaxDamage;
    public int AttackSpeed;
}

[CreateAssetMenu(menuName = "Saga/Player")]
public class Player : ScriptableObject {

    public CharacterInformation CharacterInformation;
    public PrimaryAttributes BasePrimaryAttributes;
   [HideInInspector] public PrimaryAttributes TotalPrimaryAttributes;
    public SecondaryAttributes BaseSecondaryAttributes;
    [HideInInspector]public SecondaryAttributes TotalSecondaryAttributes;
    public WeaponAttributes WeaponAttributes;
    public (int, int) DPT;
}
