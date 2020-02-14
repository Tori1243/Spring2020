using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStats : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP { get; private set; }
    
    public Stats damage;

    private void Awake()
    {
        currentHP = maxHP;
    }

    /* private void Update()
     {
         if (Input.GetMouseButtonDown(0))
         {
             TakeDamage(5);
         }
     }*/

    public void TakeDamage(int damage)
    {
        damage = Mathf.Clamp(damage, 0, int.MaxValue); //damage can never go below 0
        
        currentHP -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

        if (currentHP <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        //die in some way, run animation, start back at starting position, etc.
        //this will later be changed depending on who is dying
        Debug.Log(transform.name + " died.");
    }
}