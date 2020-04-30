using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public bool Shielding; 
    public GameObject ShieldObject;
    public int ShieldHealth;

    
    void Update()
    {
        //Get input for shielding
        if(Input.GetMouseButtonDown(1))
        {
            //Change shield variable
            Shielding = true;
            ShieldObject.SetActive(true);
            GetComponent<Health>().takeHealth(ShieldHealth);
        }
    
        //Get input for stop shielding
        if(Input.GetMouseButtonUp(1))
        {
            //return shield variable to normal
            Shielding = false;
            ShieldObject.SetActive(false);
            
        }
                   
    }
    
}