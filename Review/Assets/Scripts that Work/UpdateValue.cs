using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class UpdateValue : ScriptableObject

{
    public FloatData DeltaValue;
    public GameObject targetObject;
    public void ChangeTargetValue(FloatData targetData)
    {
        targetData.Value += DeltaValue.Value;
    }

}