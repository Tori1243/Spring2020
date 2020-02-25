using UnityEngine;
using UnityEngine.Events;

public class HealthStorage : MonoBehaviour
{
    public int Health = 100;
    public UnityEvent DeathEvent;
    public UnityEvent TakeDamageEvent;

    public void takeHealth()
    {
        Health -= 10;
        TakeDamageEvent.Invoke();
        
        if (Health == 0)
        {
            death();
        }
        
        print("Taking Health");
    }

    public void giveHealth()
    {
        Health += 10;
    }

    public void death()
    {
        DeathEvent.Invoke();       
    }

}
