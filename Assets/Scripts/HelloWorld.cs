using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloWorld : MonoBehaviour
{
    public string firstName;                // Unity can access this
    private TextMeshProUGUI textMeshPro;    // Unity cannot access this, sets 'TextMeshProUGUI' to the current textMesh script is applied to

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();  // Get component allows script to access unity asset
        textMeshPro.text = $"Hello {firstName}!";       // Sets the 'text' "component" of textMeshPro to the quoted string
    }

    void Update()
    {
        
    }
}
