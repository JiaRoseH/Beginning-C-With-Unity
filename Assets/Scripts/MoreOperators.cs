using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreOperators : MonoBehaviour
{

    void Start()
    {
        int x = 1;
        int y = 2;
        //bool result = x == y;      // outputs false, obviously
        //bool result = x != y;      // outputs true, obviously

        string playerName = null;
        //bool result = playerName != null;         // false

        int nextLevelXP = 300;                      // false
        int playerOneXP = 185;
        bool result = playerOneXP > nextLevelXP;    // false

        Debug.Log(!result);          // does not equal result baked in
        Debug.Log(result);
        
    }

    void Update()
    {
        
    }
}
