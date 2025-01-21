using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyTernery : MonoBehaviour
{
    public int currentNumber;
    private string message;

    private TextMeshProUGUI textMeshPro;
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        
    }

    public void ShowMessage()
    {
        // checks if currentNumber has a remainder or not, if modulus = 0, even, if modulus = 1, odd
        string number = (currentNumber % 2 == 0) ? "even" : "odd";
        textMeshPro.text = $"Number is {number}";
    }
}
