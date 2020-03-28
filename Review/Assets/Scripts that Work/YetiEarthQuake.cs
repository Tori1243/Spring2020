using System.Collections;
using UnityEngine;

public class YetiEarthQuake : MonoBehaviour
{
    public float WaitTimeMin;
    public float WaitTimeMax;
    public float WaitTime;
    public bool CanAttack;
    public bool AttackCycleIsRunning;
    public GameObject PulseObj;
    
    public void StartBossFight()
    {
        if (AttackCycleIsRunning == false)
        {
            CanAttack = true;
            StartCoroutine(AttackCycling());
        }
    }

    IEnumerator AttackCycling()
    {
        AttackCycleIsRunning = true; 
        while (CanAttack)
        {
            // pick a Random number to wait between attacks
            WaitTime = Random.Range(WaitTimeMin, WaitTimeMax);
            yield return new WaitForSeconds(WaitTime);
            
            // When time is up attack
            PulseAttack(); 

        }

        AttackCycleIsRunning = false;

    }

    public void PulseAttack()
    {
        // TO DO: Enemy Jump animation
        // TO DO: Hit ground
        
        // Pulse grows
        PulseObj.GetComponent<Animator>().SetTrigger("PulseCanAttack");
      

        // Does damage to other gameobj using hitbox script
    }
    
    
   
    
        
}