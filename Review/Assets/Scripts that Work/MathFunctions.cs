using UnityEngine;

[CreateAssetMenu]
public class MathFunctions : WorkSystem

{
    public FloatData dataObj;
    
    
    public override void Work()
    {
        dataObj.value++;
    }
}
