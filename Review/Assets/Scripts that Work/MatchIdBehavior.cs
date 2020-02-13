using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchIdBehavior : MonoBehaviour
{

    public List<NameID> nameIds;
    private NameID otherIDObj;

    public List<DoWork> DoWorks;
    
    private void OnTriggerEnter(Collider other)
    {
        otherIDObj = other.GetComponent<IDBehaviour>().nameIDObjs;
    }

    private void CheckID()
    {
        foreach (var obj in nameIds)
        {
            if(obj == otherIDObj)
            {
                foreach (var job in DoWorks)
                {
                    job.Work();
                }
            }
        }
    }
}
