using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class MyNull : MonoBehaviour
{

    string firstName = "Brian";
    string lastName = null;         // makes string a 'reference' type
    int? meaningOfLife = null;       // value type, need to use '?'

    void Start()
    {
        int? anotherNumber = null;
        int trueNumber = meaningOfLife ?? anotherNumber ?? 42;       // '??' checks if left is null, if it is, then trueNumber = 42
        Debug.Log(trueNumber);

        Debug.Log($"{firstName} {lastName}");
        lastName.ToUpper();                         // uppercases string, returns error since lastName DNE
    }

    void Update()
    {
        
    }
}
