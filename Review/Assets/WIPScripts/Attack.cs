using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject Player;
 

    public void OnTriggerEnter(Collider other)
    {
        GetComponent<Health>();
        {
            Destroy(Player.gameObject);
        }

    }
}
 
 