using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;

public enum Game
{
    Starfield,
    AlienIsolation,
    BaldursGateThree,
    Gollum
}

public enum Rating
{
    Amazing,
    Great,
    Mediocre,
    Trash,
    NotRated
}

public class SwitchStatements : MonoBehaviour
{

    public Game game;
    public Rating rating;

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
        // string game = "";
        // switch(rating)
        // {
        //     case Rating.Amazing:
        //         game = "Baldur's Gate 3";
        //         break;
        //     case Rating.Great:
        //         game = "Alien Isolation";
        //         break;
        //     case Rating.Mediocre:
        //         game = "Starfield";
        //         break;
        // }
        // textMeshPro.text = game;

        switch (game)
        {
            case Game.BaldursGateThree:
            case Game.Starfield:
                goto case Game.AlienIsolation;              // sends above code to the Alien isolation review
            case Game.AlienIsolation:
                textMeshPro.text = "This game is " + Rating.Amazing;
                break;
            default:
                textMeshPro.text = "Only a mother could love";
                break;            
        }
    }
}
