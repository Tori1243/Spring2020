﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;
    
    private Transform target;
    private NavMeshAgent agent;
    private CharCombat combat;
    void Start()
    {
        target = PlayerManager.instance.player.transform; //put it on the player manager so it can be saved between scenes
        agent = GetComponent<NavMeshAgent>();
        combat = GetComponent<CharCombat>();
    }

    
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
        }

        if (distance <= agent.stoppingDistance)
        {
            CharStats targetStats = target.GetComponent<CharStats>();

            if (targetStats != null)
            {
                combat.Attack(targetStats);
            }
            
            FaceTarget();
        }
    }

    private void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized; //direction to the target
        Quaternion lookRotation =
            Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z)); //rotation to point to target
        transform.rotation = lookRotation; //now update the current rotation value based on above values
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}