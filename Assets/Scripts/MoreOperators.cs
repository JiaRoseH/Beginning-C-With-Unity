using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreOperators : MonoBehaviour
{

    void Start() // to comment all out, ctrl + /
    {
        // int x = 1;
        // int y = 2;
        // //bool result = x == y;      // outputs false, obviously
        // //bool result = x != y;      // outputs true, obviously

        // string playerName = null;
        // //bool result = playerName != null;         // false

        // int nextLevelXP = 300;                      // false
        // int playerOneXP = 185;
        // bool result = playerOneXP > nextLevelXP;    // false

        // Debug.Log(!result);          // does not equal result baked in
        // Debug.Log(result);

        int coins = 100;
        int totalLives = 6;
        int maxLives = 10;
        bool isPremiumMember = false;

        bool shouldIncreaseDifficulty = totalLives >= 5 && !isPremiumMember;
        Debug.Log(shouldIncreaseDifficulty);

        bool shouldIncreaseLifeCount = coins >= 100 && totalLives < maxLives || isPremiumMember;
        Debug.Log(shouldIncreaseLifeCount);

        string firstName = null;
        bool isUpperCase = firstName != null && firstName.ToUpper() == "JIA";     // evaluates to false because the first case is false, skips to next line
        Debug.Log(isUpperCase);
    }

    void Update()
    {
        
    }
}
