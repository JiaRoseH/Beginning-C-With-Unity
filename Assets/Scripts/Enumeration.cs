using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// createes enumeration for 'Down' and 'Up'. Put above class so can be used throughout code
public enum DamageMult      // best practice to capitalize
{
    Single = 1,                  // we may assign value to enum
    Double,                  // if no value is specified. C# will automatically increment by 1
    Quad = 4                      
}

public class Enumeration : MonoBehaviour
{
    public DamageMult multiplier;        // creates a dropdown with values described in enum
    public int damageAmount = 1000;
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    public void ShowMessage()
    {
        textMeshPro.text = $"Damage is: {damageAmount * (int)multiplier}";     // (int) converts enum to integer, casting
    }
}
