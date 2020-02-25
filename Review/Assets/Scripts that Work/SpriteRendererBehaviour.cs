using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteRendererBehaviour : MonoBehaviour
{
    private SpriteRenderer spriteRendererObj;
    public ColorData colorDataObj;
    public UnityEvent startEvent;

    void Start()
    {
        spriteRendererObj.GetComponent<SpriteRenderer>();
        startEvent.Invoke();
        
    }

    public void ChangeSpriteColor(ColorData colorDataObj)
    {
        spriteRendererObj.color = colorDataObj.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
