using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpSystem : MonoBehaviour
{
    public int currentLevel;
    public int baseExp = 20;
    public int currentExp;

    public int expForNextLevel;
    public int expDifferenceToNextLevel;
    public int totalExpDifference;

    public float fillAmount;
    public float reverseFillAmount;

    public int attributePoint;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddExp", 1f, 1f);
    }

    public void AddExp() {
        CalculateLevel(5);
    }

    void CalculateLevel(int amount) {
        currentExp += amount;

        int temp_cur_level = (int)Mathf.Sqrt(currentExp / baseExp)+1;

        if(currentLevel!= temp_cur_level) {
            currentLevel = temp_cur_level;
        }

        expForNextLevel = baseExp*currentLevel*currentLevel;
        expDifferenceToNextLevel = expForNextLevel-currentExp;
        totalExpDifference = expForNextLevel - (baseExp * (currentLevel-1) * (currentLevel - 1));

        fillAmount = (float)expDifferenceToNextLevel / (float)totalExpDifference;
        reverseFillAmount = 1- fillAmount;

        attributePoint = 1 * (currentLevel - 1);
    }

}
