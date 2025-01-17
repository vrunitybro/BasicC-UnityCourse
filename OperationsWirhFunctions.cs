 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class OperationsWirhFunctions : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        //how to print
        //sum of two variables

        int a = 7;
        int b = 6;

        float c = 5.8f;
        float d = 4.8f;

        int sum = (a + b);

        float div = (d / c);

        string greeting = ("Welcome!");
        
        //print variables
        print(a);

        Debug.Log(b);

        //print the sum of two variables
        print(a + b);

        //print strings

        print(greeting);

        print("Hello VRUnitry Bro");

        //print string and integrer

        print("The value of a is: " + a );

        //print  string and a sum. CHECK RESULT IN CONSOLE

        print("The sum of a and b is " + a + b);

        //print  string and a sum

        print("The sum of a and b is " + (a - b));

        //print string and variable sum
        print("The addition of a and b is " + sum);

        //print string, and variables. Notice the spaces " the sum of "

        print(greeting + " the sum of " + a + " and " + b + " is: " + sum);

        //create a gameobject and attach the script to it to test

        print(div);

        //Casting: Converting a float into an integrer

        int sum2 = (int)c + (int)d;

        print(sum2);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
