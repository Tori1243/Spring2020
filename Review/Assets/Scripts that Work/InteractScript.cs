using UnityEngine;
using UnityEngine.Events;

public class InteractScript : MonoBehaviour
{
    public bool canInteract = false;

    public GameObject interactableObj;
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Interact")
        {
           
            interactableObj = other.gameObject;
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Interact")
        {
          
            canInteract = false;
        }
    }
    //hello
    public void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            interactableObj.GetComponent<InteractEvent>().interactEvent.Invoke();
        }
    }
}