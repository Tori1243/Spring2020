using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    void Update()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
