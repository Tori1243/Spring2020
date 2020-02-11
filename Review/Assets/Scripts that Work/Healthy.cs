
using UnityEngine;

[CreateAssetMenu]

public class Healthy: ScriptableObject
{
    public FloatData healthData;
    public FloatData damagerData;

    public void StartDamage()
    {
        healthData.SetValue(damagerData);
    }
}
