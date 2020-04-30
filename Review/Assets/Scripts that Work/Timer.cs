using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Timer : MonoBehaviour
{
    public UnityEvent endOfTimerEvent;
    public float time;
    
    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(time);
        endOfTimerEvent.Invoke();
    }

}