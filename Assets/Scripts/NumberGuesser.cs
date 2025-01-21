using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberGuesser : MonoBehaviour
{
    public int guess;
    public int randomNumber;

    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = "Pick a number bewteen 1 through 10";
        randomNumber = Random.Range(1, 10);
    }

    void Update()
    {
        
    }

    public void CheckGuess()
    {
        if (guess < 10 && guess > 1)
        {
            if (guess == randomNumber)
            {
                textMeshPro.text = "Correct! Well done!";
            }
            else if (guess > randomNumber)
            {
                textMeshPro.text = "Too high bozo";
            }
            else
            {
                textMeshPro.text = "Too low bozo";
            }
        }
        else
        {
            textMeshPro.text = "I said 1 through 10 bruh";
        }
    }

}
