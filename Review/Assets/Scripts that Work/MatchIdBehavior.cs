using UnityEngine;

public class MatchIdBehaviour : IDBehaviour
{
    public WorkSystemManager workSystemManagerObj;
    private NameID otherIdObj;
    
    private void OnTriggerEnter(Collider other)
    {
        otherIdObj = other.GetComponent<IDBehaviour>().nameIDObjs;
        CheckId();
    }

    private void CheckId()
    {
        foreach (var obj in workSystemManagerObj.workIdList)
        {
           
            if (otherIdObj == obj.nameIdObj)
            {
                obj.workSystemObj.Work();
            }
        }
    }
}