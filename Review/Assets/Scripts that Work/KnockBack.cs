using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour

{
    public float KnockBackSpeed;
    public GameObject attacker;
    public void OnHit()
    {
        Vector3 direction = attacker.transform.position - transform.position;

        GetComponent<CharacterController>().Move(direction * KnockBackSpeed);

    }
   // direction = ai.position - player.position;

  // distance = 1; destination = direction * distance
}
