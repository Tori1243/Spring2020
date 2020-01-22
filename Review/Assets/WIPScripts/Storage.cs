using UnityEngine;

[CreateAssetMenu]

public class Storage :ScriptableObject
{
    public ObjectCollection Collection;
	
    public void Call(ScriptableObject obj)
    {
        Collection.ObjectList.Add(obj);
    }
}
