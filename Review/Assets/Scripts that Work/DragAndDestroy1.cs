using UnityEngine;

public class DragAndDestroy : MonoBehaviour
{
    public bool draggy = false;
    public bool collisionOn = false;
    private Vector3 position;
    
   
    public void startDrag()
    {
        position = gameObject.transform.position;
        draggy = true;
    }

    public void drag()
    {
        transform.position = Input.mousePosition;
    }

    public void drop()
    {
        if (!collisionOn)
        {
            gameObject.transform.position = position;
        }

        draggy = false;
    }
}