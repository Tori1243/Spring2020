using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class Restart : MonoBehaviour

{
    public GameObject SpawnSpot;
    public UnityEvent DeadEvent;
        
    
    public void ReturnToSpawn()
    {
        // spawn to spawn point
        GetComponent<CharacterController>().enabled = false;
        transform.position = SpawnSpot.transform.position;
        GetComponent<CharacterController>().enabled = true;
        GetComponent<Health>().HealthStorage = 100;
        
    DeadEvent.Invoke();
    }
    
    
    //not destroy himself
    //restore health to full
}
