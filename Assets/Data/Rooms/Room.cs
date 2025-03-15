using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DialogueLine {
    [TextArea]
    public string line;
}

[CreateAssetMenu(menuName = "Saga/Room")]
public class Room : ScriptableObject {

    public List<DialogueLine> description;
    public string roomName;
    public bool isCombatEncounter;
}
