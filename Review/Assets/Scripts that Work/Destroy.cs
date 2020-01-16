using UnityEngine;
using UnityEngine.Events;

public class DestroyObject : MonoBehaviour
{
    public UnityEvent ClickEvent;

    private void OnMouseDown()
    {
        ClickEvent.Invoke();
        Destroy(gameObject);
    }
}