using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//handles interaction with the Enemy

[RequireComponent(typeof(EnemyStats))]
[RequireComponent(typeof(EnemyController))]
[RequireComponent(typeof(CharCombat))]

public class Enemy : Interactable
{
    private PlayerManager playerManager;
    private CharStats myStats; //referencing the stats of the enemy
    
    
    private void Start()
    {
        playerManager = PlayerManager.instance;
        myStats = GetComponent<CharStats>();
    }

    public override void Interact()
    {
        base.Interact();
        CharCombat playerCombat = playerManager.player.GetComponent<CharCombat>();

        if (playerCombat != null)
        {
            playerCombat.Attack(myStats);
            Debug.Log("you are attacking the enemy");
            
        }
        
    }
}