using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Saga/Class/Mage")]
public class Mage : PlayerClass
{
    public override void SetPlayerStats(PlayerController playerController) {
        playerController.currentPlayer.CharacterInformation.playerClass = "Mage";
        playerController.currentPlayer.BasePrimaryAttributes.Strength = 1;
        playerController.currentPlayer.BasePrimaryAttributes.Dexterity = 1;
        playerController.currentPlayer.BasePrimaryAttributes.Intellect = 1;
        playerController.currentPlayer.BasePrimaryAttributes.Constitution = 1;
        playerController.currentPlayer.BasePrimaryAttributes.WillPower = 1;

        playerController.CalculateTotalStats();

        playerController.currentPlayer.CharacterInformation.currentMana = playerController.currentPlayer.TotalSecondaryAttributes.MaxMana;
        playerController.currentPlayer.CharacterInformation.currentHealth = playerController.currentPlayer.TotalSecondaryAttributes.MaxHealth;
    }
}
