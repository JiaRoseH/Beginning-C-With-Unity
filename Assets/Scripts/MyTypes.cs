using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTypes : MonoBehaviour
{
    // The types of simple variables we can create and examples
    public string message = "Strings contain text, not cheese";
    public string phoneNumber = "1234567891";   // still just text
    public string whiteSpace = " ";
    public string emptyString = "";

    public char tempType = 'C';
    
    public bool weClothesKill = true;
    public bool lovingRelationship = false;

    public int myNumber = 1_123_456_789;
    public uint anotherNumber = 2147483648;     // "2147483647" is the int limit b/c 32 bits. Can use uint to remove need for +ve or -ve
    // public uint errorNumber = -1;               // uint cannot store negative

    public long reallyBigNumber = 9_223_372_036_854_775_807;

    public double pi = 3.14159265359;       // default decimal type, 64 bit
    public float temp = 95.6F;              // must declare float explicily w/ 'f' or 'F' since double is assumed, 32 bit
    public decimal cashOnHand = 1.99M;      // similarly, must add 'm' or 'M'

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
