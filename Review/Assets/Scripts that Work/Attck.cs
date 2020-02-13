using UnityEngine;

public class Attck : MonoBehaviour {
    public int AttackAmount;
    public void OnTriggerEnter(Collider other)
    {
        print("attacking");
        if (other.GetComponent<Health>())
            other.GetComponent<Health>().ChangeHealth(AttackAmount);
    }
}