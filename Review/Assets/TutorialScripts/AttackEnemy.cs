using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacks : MonoBehaviour
{
    public GameObject Hitbox;
    public float Timer;
    public bool AttacksIsRunning = false;
   
    void OnTriggerEnter()
    {
       
        if (AttacksIsRunning == false)
        {
            StartCoroutine(Attacks());
        }
            
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
}
