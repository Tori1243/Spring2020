using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCoins : MonoBehaviour
{
    public GameObject coin;

    public void InstantiateOnEnemy()
   
    {
        Instantiate(coin, transform.position, Quaternion.identity);
    }
}
