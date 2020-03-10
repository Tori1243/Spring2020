using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public List<Collectable> CollectableList;

    public void AddToCollections(Collectable collectableObj)
    {
        CollectableList.Add(collectableObj);
    }

    public void RemoveFromCollection(Collectable collectableObj)
    {
        for (var index = CollectableList.Count - 1; index >= 0; index--)
        {
            var obj = CollectableList[index];
            if (obj == collectableObj)
            {
                CollectableList.Remove(collectableObj);
            }
        }
    }

    public void ClearCollection()
    {
        CollectableList.Clear();
    }
    
}
