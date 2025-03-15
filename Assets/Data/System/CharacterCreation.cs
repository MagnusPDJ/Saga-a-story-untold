using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Windows;

[Serializable]
public class CharacterCreation : MonoBehaviour
{
    public TMP_Dropdown classSelection;
    public TMP_InputField inputField;
    public TextMeshProUGUI textNameError;
    public PlayerClass[] playerClasses;
    [HideInInspector] PlayerController playerController;

    void Awake() {
        playerController = GetComponent<PlayerController>();
        playerClasses[0].SetPlayerStats(playerController);
        playerController.currentPlayer.CharacterInformation.playerName = "Adventurer";
        classSelection.onValueChanged.AddListener(SelectClass);
        inputField.onEndEdit.AddListener(AcceptStringInput);
    }

    private void AcceptStringInput(string userInput) {
        IEnumerable<char> input = userInput;
        if (input.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)) && !input.Contains('-') && !input.Contains('\u0027')) {
            textNameError.text="Invalid name";
        } else if (userInput.Length >= 31) {
            textNameError.text = "Name is too long. Max 30 characters!";
        } else {
            playerController.currentPlayer.CharacterInformation.playerName = userInput;
            textNameError.text = "";
        }
        
    }
    private void SelectClass(int playerClass) {
        if (playerClass == 0) {
            playerClasses[0].SetPlayerStats(playerController);
        } else if (playerClass == 1) {
            playerClasses[1].SetPlayerStats(playerController);
        } else if (playerClass == 2) {
            playerClasses[2].SetPlayerStats(playerController);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
