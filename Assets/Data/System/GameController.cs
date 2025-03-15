using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameController : MonoBehaviour {

    public TextMeshProUGUI displayText;

    [HideInInspector] public RoomNavigation roomNavigation;
    [HideInInspector] public PlayerController playerController;
    [HideInInspector] public CombatController combatController;

    private List<string> actionLog = new();

    [SerializeField]
    [Range(0f, 1f)]
    float visibleTextPercent;
    [SerializeField] float timePerLetter = 0.05f;
    float totalTimeToType, currentTime;
    [SerializeField] float skipTextWaitTime = 0.1f;

    string lineToShow;

    int index;
    Coroutine skipTextCoroutine;

    void Awake()
    {
        roomNavigation = GetComponent<RoomNavigation>();
        playerController = GetComponent<PlayerController>();
        combatController = GetComponent<CombatController>();
    }

    void Start() 
    {
        DisplayRoomText();
        DisplayLoggedText();
        InisiateText();
    }

    void Update() {
        if (index <= roomNavigation.currentRoom.description.Count) {
            if (Input.GetMouseButtonDown(0)) {
                PushText();
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftControl)) {
            skipTextCoroutine = StartCoroutine(SkipText());
        }
        if (Input.GetKeyUp(KeyCode.LeftControl)) {
            if (skipTextCoroutine != null) {
                StopCoroutine(skipTextCoroutine);
            }
        }
        TypeOutText();
    }

    public void DisplayLoggedText() {
        lineToShow = string.Join("\n", actionLog.ToArray());
    }

    public void DisplayRoomText() {
        string combinedText = roomNavigation.currentRoom.description + "\n";
       
        LogStringWithReturn(combinedText);
    }

    public void LogStringWithReturn(string stringToAdd) {
        actionLog.Add(stringToAdd + "\n");
    }
    
    //Homebrew to slowprint text
    private void InisiateText() {
        index = 0;
        CycleLine();
    }

    private void TypeOutText() {
        if (visibleTextPercent >= 1f) {
            return;
        }
        currentTime += Time.deltaTime;
        visibleTextPercent = currentTime / totalTimeToType;
        visibleTextPercent = Mathf.Clamp(visibleTextPercent, 0f, 1f);
        UpdateText();
    }

    private void UpdateText() {
        int totalLetterToShow = (int)(lineToShow.Length * visibleTextPercent);
        displayText.text = lineToShow[..totalLetterToShow];
    }

    private void PushText() {
        if (visibleTextPercent < 1f) {
            visibleTextPercent = 1f;
            UpdateText();
            return;
        }
        CycleLine();
    }

    private void CycleLine() {
        if (index >= roomNavigation.currentRoom.description.Count) {
            Debug.Log("There is no more text to show");
            if (roomNavigation.currentRoom.isCombatEncounter) {
                index += 1;
                combatController.InisiateCombat();

            }
            return;
        }
        DialogueLine line = roomNavigation.currentRoom.description[index];

        lineToShow = line.line;
        for (int i = 0; i < lineToShow.Length; i++) {
            lineToShow = lineToShow.Replace("{playerName}", playerController.GetPlayerName());
        }
        totalTimeToType = lineToShow.Length * timePerLetter;
        currentTime = 0f;
        visibleTextPercent = 0f;

        index += 1;
    }

    IEnumerator SkipText() {
        while (true) {
            yield return new WaitForSeconds(skipTextWaitTime);
            PushText();
        }
    }

    public void CompileGoddamnit() {
        
    }
}
