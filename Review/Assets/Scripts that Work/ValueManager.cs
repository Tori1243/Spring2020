using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class ValueManager : MonoBehaviour
{
    public FloatData GemTotal;

    public void ChangeGemTotal(float delta)
    {
        GemTotal.Value += delta;
    }


