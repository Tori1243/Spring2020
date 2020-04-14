using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    public GameObject Hitbox;
    public float Timer;
    public float TimeBetweenAttacks;
    public bool CanAttack;
    public bool AttacksIsRunning = false;
   
    void OnTriggerEnter()
    {
        CanAttack = true;   
        
        StartCoroutine(AttackCycle());
        
    }

    IEnumerator Attacks()
    {
        AttacksIsRunning = true;
        //Turn on Hit box
        Hitbox.SetActive(true);
        
        //Set Timer
        yield return new WaitForSeconds(Timer);
        
        //Turn off
        Hitbox.SetActive(false);

        AttacksIsRunning = false;
    }

    IEnumerator AttackCycle()
    {
        while (CanAttack == true)
        {
            
            if (AttacksIsRunning == false)
            {
                StartCoroutine(Attacks());
            }

           yield return new WaitForSeconds(TimeBetweenAttacks);
        }
    }

    private void OnTriggerExit()
    {
        CanAttack = false;
        
    }
}
