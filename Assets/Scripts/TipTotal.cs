using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class TipTotal : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    public int amount = 0;
    public float percentage = 0.2f;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        
    }

    public void DisplayMessage()
    {
        float tipAmount = (float) amount + percentage;
        int totalAmount = (int) tipAmount + amount;

        textMeshPro.text = $"{totalAmount}";
    }
}
