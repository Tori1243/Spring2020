using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharStats
{
    public EnemyStats enemyStat;
    public Color deadColor = Color.black;
    
    public override void Die()
    {
        base.Die();
        //kill the player somehow
        gameObject.GetComponent<Renderer>().material.color = deadColor;
        PlayerManager.instance.KillPlayer();
    }

    /* private void OnTriggerEnter(Collider other)
     {
         if (enemyStat.maxHP >= 0)
         {
             TakeDamage(5);
         }
     }*/
}