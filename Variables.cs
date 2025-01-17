using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Declaring variables
    //type, name , value
    //Give meanunful names so you can know what the variable does
    // End each statement with semicolon

    //intergrer is a whole number
    int score = 50;
    
    //double is 64 bit number (more precise than a float)
    //float is a 32 bit number (add f at the end or you will get an error or C# will be confused)

    float power = 2.4f;
    double health = 3.564;

    //character based  or text variable
    string myName = "VRUnity Bro";

    //can be true or false. Used on conditional statements
    bool isAlive = true;

    //Comments are sued to document code.
    /* This wont be taken as code
     Good code documents itself */
    //you can select the text and pres CTRL+K , C to make a cooment

}
