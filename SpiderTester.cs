using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Step 1: Attach this script to a GameObject in Unity to run the tests
public class SpiderTester : MonoBehaviour
{
    // Step 2: The Start method is called when the game begins
 
    void Start()
    {
        // Step 3: Create an instance of the Spiderman class (child class)

        SpiderMan spiderMan = new SpiderMan();

        // Step 4: Call inherited methods from the Player class
        // This should print Spiderman's custom attack
        // Display default name and health
        spiderMan.PlayerInfo();
        spiderMan.AttackDefault();
        spiderMan.ReplenishWeb(2f);


        // Step 5: Change Spiderman's name and health using inherited properties
        spiderMan.Name = "SpiderBoy";
        spiderMan.Health = 80f;
        // Step 6: Display updated information
        spiderMan.PlayerInfo();
        // Step 7: Replenish Spiderman's web and test the unique function
        spiderMan.ReplenishWeb(6f);
        spiderMan.Attack();
        
        

        
        

        // Step 8: Create another Spiderman with specific values using the parameterized constructor
        SpiderMan spiderMan2 = new SpiderMan("SpiderMan 2", 300f);
        spiderMan2.PlayerInfo();
        spiderMan2.Attack();
        spiderMan2.ReplenishWeb(10f);

    }

 
}
