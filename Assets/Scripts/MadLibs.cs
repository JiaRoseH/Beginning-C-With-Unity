using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MadLibs : MonoBehaviour
{
    public string statement = "";
    public string verb = "";
    public string noun = "";
    public string adjective = "";
    public int number = 1;
    public string pluralNoun = "";
    public float percent = 99.999f;


    private TextMeshProUGUI textMeshPro;
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"The is statement is {statement}. I did not {verb} the {noun}. I am not guilty. I am a {adjective} person. The act was performed by {number} wandering {pluralNoun}. I am {percent}% sure of this.";
    }

    void Update()
    {
        
    }
}
