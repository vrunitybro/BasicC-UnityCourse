using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Step 1: Inherit from the InheritancePracticePlayer class using ':' syntax
public class SpiderMan : InheritancePracticePlayer
{
    // Step 2: Add unique properties specific to Spiderman (this is an extension of the parent class)
    // Spiderman-specific ability

    private float webAmount = 5;


    // Step 3: Create an empty constructor
    // This will use default values from the Player class

    public SpiderMan()
    {

    }



    // Step 4: Create a constructor to initialize name and health using the parent class's properties
    // Use inherited setter from InheritancePracticePlayer class (Parent)
    // Use inherited setter from InheritancePracticePlayer class (Parent)

    public SpiderMan(string name, float health)
    {
        this.Name = name;
        this.Health = health;

    }

    // Step 5: Add a method to replenish Spiderman's web
    // needs a float paramenter named web so when is called
    //It will need a float to be passed and do its job

    public void ReplenishWeb(float web)
    {
        this.webAmount = web;
        Debug.Log(Name + " replenish web " +  web);
    }

    

    // Step 6: Override the 'Attack' method to give Spiderman a unique attack style

    public override void Attack()
    {
        Debug.Log(Name + " Spider sting attack! ");
    }



}
