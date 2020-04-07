using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckForRock : MonoBehaviour
{
    public UnityEvent checkRock;
    public float interactable;
    public bool on = false;
    public bool Cube3;
    public bool Cube4;
    public bool Cube6;
    public bool Cube7;
    public bool Cube10;
    public bool Cube12;
    public bool Cube14;

    public void CheckRockOn(int RockNumber)
    {
        if (RockNumber == 3)
        {
            Cube3 = true;
        }
        
        if (RockNumber == 4)
        {
            Cube4 = true;
        }
        
        if (RockNumber == 6)
        {
            Cube6 = true;
        }
        
        if (RockNumber == 7)
        {
            Cube7 = true;
        }
        
        if (RockNumber == 10)
        {
            Cube10 = true;
        }
        
        if (RockNumber == 12)
        {
            Cube12 = true;
           
        }
        
        if (RockNumber == 14)
        {
            Cube14 = true;
        }

        if (Cube3 && Cube4 && Cube6 && Cube7 && Cube10 && Cube12 && Cube14)
        {
            checkRock.Invoke();
        }
    }