
using UnityEngine;

[CreateAssetMenu(menuName = "Single Variable/BoolData")] 


public class BoolData : ScriptableObject
{
   public bool Value;

   public void SetValue(bool valueChange)
   {
      Value = valueChange;
   }
}
