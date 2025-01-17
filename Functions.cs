using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    /*FUNCTION 
    -block of code that can be reused over and over
    -The group in that code will help us write cleaner code
    -Its easier to maintain*/

    /*
     * Functions that does not return a value
     * 1.1 Declare the function using void
     * 1.2 Call the function 
     * 1.3 Use arguments if needed
     * 
     * Functions that RETURN a value
     * 2.1 Instead of void declare the typle of variable to return
     *  Name of the function
     *  add code
     * 2.2 return
     * 2.3 call the function
     * 
     
     */


    int sum = 5 + 6;
   

    // Start is called before the first frame update
    void Start()
    {
        //(1.2)
        FunctionThatdoesntReturnValues();
        //Call the function and customize the values in the same order
        //in this case c = 3 and d= 18
        FunctionWithArguments(3, 18);

        //(2.3) Call the function
        print("This returns an integrer of: " + FunctionThatReturnsAValue());

        //or create a variable that stores the return result of the function and 

        int sum = FunctionThatReturnsAValue();

        //print the variable instead of calling the function

        print("This is getting the returned value in a variable that is: " + sum);

        //Print the result of a function that returns an interger and uses parameters

        int sum2 = Function2ThatReturnsAValueWithParameters(20,8);

        print("Print a function that returns a value with parameters: " + sum2);

        //Reuse the same function with different parameter to get a different result

        int sum3 = Function2ThatReturnsAValueWithParameters(10, 6);

        print("I ma reusing the functions with different parameters " + sum3);



    }


    //(1.1)
    void FunctionThatdoesntReturnValues()
    {
        print("The sum os a and b is: " + sum);
        print("The result os 10/5 is: " + (10 / 5));
        
    }

    // we can add parameters/arguments to the function
    //We change the numbers when the code is executing

    //(1.3)
    void FunctionWithArguments(int c, int d) //you can add: float z, bool y, string h, if needed
    {
        print("The substraction of c and d is: " + (c - d));
    }

    //Functions that returns an Integrer
    //(2.1)
    int FunctionThatReturnsAValue()
    {
        //(2.2)
        return 7 + 2;
    }

    //Function that returns an interger and uses parameters
    int Function2ThatReturnsAValueWithParameters(int f, int p)
    {
        return f - p;
    }

    /*
     * you can have 2 functions with the same name as long as
     * one doest use parameters and the other does use them.
     * You can call a function multiple times even if you change paramenters
     
     */
}
