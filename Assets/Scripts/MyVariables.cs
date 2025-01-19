using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyVariables : MonoBehaviour
{
    // Just playing with variables for demonstration
    
    private int health = 100;               // Unity editor cannot see this b/c 'private'
    private int Health = 100;               // Demonstrating how uppercase and lowercase matters when making variables
    private int HeAlTh = 100;
    private int myHealth = 100;

    private string messageForTheTextView = "This space for rent";       // Best practice for defining variable w/ multiple words
    private const int PlayerScorew = 100;   // Constant variable type is unchangeable
    // private const int PLAYER_SCORE = 100;

    public string firstName;                // Unity can access these b/c 'public'
    public string lastName;

    private TextMeshProUGUI textMeshPro;    // Unity cannot access this, sets 'TextMeshProUGUI' to the current textMesh script is applied to

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();             // Get component allows script to access unity asset
        textMeshPro.text = $"Hello {firstName} {lastName}!";       // Sets the 'text' "component" of textMeshPro to the quoted string
    }

    void Update()
    {

    }
}
