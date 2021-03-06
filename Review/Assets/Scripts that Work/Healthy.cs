﻿using UnityEngine;
using UnityEngine.Events;

public class Healthy : MonoBehaviour {
    public UnityEvent DeathEvent;

    public int health = 100;
    public void ChangeHealth(int NewHealth){
        health = health + NewHealth;
        KillPlayer();
    
    }
    public void KillPlayer()
    {
        if (health < 0 && gameObject.tag == "Player")
        {
            DeathEvent.Invoke();
        }
        else
        {
            return;
        }
    }

}