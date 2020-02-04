
using UnityEngine;

public class CheckBoolData : MonoBehaviour
{
    public BoolData boolDataObj;

    void Update()
    {
        if (boolDataObj.Value)
        {
            print(message: true);
        }

        else
        {
            //Do false work  
        }
    }
}
