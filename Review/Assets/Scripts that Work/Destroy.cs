using UnityEngine;
using UnityEngine.Events;

public class Destroy : MonoBehaviour
{
    public UnityEvent ClickEvent;

    private void OnMouseDown()
    {
        ClickEvent.Invoke();
        Destroy(gameObject);
    }
}