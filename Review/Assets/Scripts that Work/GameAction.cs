  
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Basics
{
    [CreateAssetMenu(menuName = "Actions/GameAction")]
    public class GameAction: ScriptableObject
    {
        public UnityAction<object> Raise;

        public void OnRaise(float obj)
        {
            Raise(obj);
        }

        public void raise(List<Vector3Data> points)
        {
            throw new System.NotImplementedException();
        }
    }
}