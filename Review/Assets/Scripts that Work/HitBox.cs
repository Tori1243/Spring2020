using System.Collections;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        
        print(other.gameObject);
        if (other.GetComponent<Health>())
        {
            other.GetComponent<Health>().takeHealth();
            print("Hitting Something");
        }

        if (other.GetComponent<KnockBack>())
        {
            other.GetComponent<KnockBack>().attacker = transform.parent.parent.gameObject;
            other.GetComponent<KnockBack>().OnHit();

        }

    }