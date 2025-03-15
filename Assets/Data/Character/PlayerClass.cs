using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerClass : ScriptableObject
{
    public string keyWord;
    public abstract void SetPlayerStats(PlayerController playerController);
}
