using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName = "Mark";               // declare variable and assign value
    public int characterLevel = 1;
    public int experience = 5;
    public int characterExperience = 1;
    public float itemDurability = 1.456f;      // the f confirms the value is a float not a decimal or double

    // Start is called before the first frame update
    void Start()
    {
        print("Hello There - I'm your first game character");
        print("My name is " + characterName);

        experience = (int)itemDurability;   // makes sure float value is cast to an integer
        print("My current Item durability is " + itemDurability.ToString());

        experience = (int)(itemDurability * 15f) / characterLevel;      // cast flat to int
        print("My current experience is " + experience.ToString());

        bool equipable = false;
        if (equipable)
        {
            print("I can accept various types of equipment");
        }
        else
        {
            print("I cannot accept any equipment");
        }
    }
    public int LevelUp()               // make method cacessible to other classes
    {
        characterLevel += 1;
        return characterLevel;
    }
    public int increaseExperience(int pExp)
    {
        characterExperience += pExp;
        return characterExperience;
    }
}
