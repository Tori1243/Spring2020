using UnityEngine;

public class Teleport : MonoBehaviour

{
    public GameObject TeleportSpot;
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject);
        print(TeleportSpot.transform.position);
        other.GetComponent<CharacterController>().enabled = false;
       other.gameObject.transform.position = TeleportSpot.transform.localPosition;
        other.GetComponent< CharacterController>().enabled = true;
        //other.gameObject.transform.position = new Vector3(0, 0, 0);

    }
}
