using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyOperators : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        
    }

    public void DisplayMessage()        // Method
    {
        int xp = 990;
        xp = xp + 10;
        xp += 10;
        xp -= 10;
        xp *= 10;
        xp /= 10;
        
        int strength = 18;              // strength = 18
        int stat = strength++;          // stat = 19

        int joyDivision = 5 / 2;        // int returns '2'
        int joyDiv = 5 % 2;             // modulus operator returns 1 when remainder, 0 when no remainder

        string firstName = "Jia";
        string lastName = "Holt";
        string fullname = firstName + " " + lastName;   // must input space

        int problem = 3 - 3 * 6 + 2;    // prefer parenthesis (3 - 6)

        float conversion = (float) 100;
        int largeNumber = 1_000_000;
        byte smallNumber = (byte) largeNumber;  // outputs '64' from 1,000,000... lots of data loss

        textMeshPro.text = $"{problem}";
    }
}
