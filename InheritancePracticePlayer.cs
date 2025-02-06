using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Step 1: Define the parent class 'Player' (This will NOT inherit from MonoBehaviour since it's a plain C# class)
public class InheritancePracticePlayer
{
    // Step 2: Declare private variables for hero name and health (Encapsulation)
    private string heroName = "Defaul Hero";
    private float heroHealth = 100f;


    // Step 3: Create an empty constructor (Default constructor)
    // This constructor doesn't do anything but is useful if no values are provided

    public InheritancePracticePlayer()
    {

    }


    // Step 4: Create a constructor with parameters to initialize heroName and heroHealth
    // Use 'this' keyword to refer to the class's variables

    public InheritancePracticePlayer(string playerName, float playerHealth)
    {
        this.heroName = playerName;
        this.heroHealth = playerHealth;
    }


    // Step 5: Create public getters and setters for the private variables
    // This allows controlled access to private variables in child object
    
    public string Name
    { 
        get { return heroName; }  // Getter
        set { heroName = value; } // Setter
    }
    public float Health
    { 
        get { return heroHealth; } 
        set { heroHealth = value; } 
    }

    // Step 6: Create a  method 'AttackDefault' that can be used in the child classes
    public void AttackDefault()
    {
        Debug.Log(Name + " Generic Attack!");
    }

    // Step 7: Create a virtual method 'Attack' that can be overridden in child classes

    public virtual void  Attack()
    {
        Debug.Log(heroName + " is attacking.");
    }


    // Step 8: Create a method to display player information

    public void PlayerInfo()
    {
        Debug.Log("My name is " + heroName + " and my health is: " + heroHealth);
    }
}
