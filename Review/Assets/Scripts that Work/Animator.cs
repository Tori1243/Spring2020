using System.Collections;
using UnityEngine;

public class Animator: MonoBehaviour, IEnumerable
{
    public Animation anim;

    void Start()
    {
        anim = GetComponent<Animation>();
        foreach (AnimationState state in anim)
        {
            state.speed = 0.5F;
        }
    }

    public IEnumerator GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
}