using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int currentHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        print("CUBE Current Health : " + takeDamage(20).ToString());
    }

    // Update is called once per frame
    public int takeDamage(int pAmt)
    {
        currentHealth -= pAmt;
        return currentHealth;
    }
}
