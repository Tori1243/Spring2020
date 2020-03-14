using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class CheckForLight : MonoBehaviour
{
   public UnityEvent checkLight;
   public float interactable;
   public bool on = false;
   public GameObject light;
   public bool GoodLight1;
    public bool GoodLight2;
    public bool GoodLight3;
    public bool GoodLight4;
    public bool BadLight5;
    public bool BadLight6;
    public bool BadLight7;
    public bool BadLight8;

   public void CheckLightOn(int BallNumber)
   {

       if (BallNumber == 1)
       {
           GoodLight1 = true;
       }
       
       if (BallNumber == 2)
       {
           GoodLight2 = true;
       }
       
       if (BallNumber == 3)
       {
           GoodLight3 = true;
       }
       
       if (BallNumber == 4)
       {
           GoodLight4 = true;
       }
       
       if (BallNumber == 5)
       {
          BadLight5 = true;
       }
       if (BallNumber == 6)
       {
           BadLight6 = true;
       }
       if (BallNumber == 7)
       {
           BadLight7 = true;
       }
       if (BallNumber == 8)
       {
           BadLight8 = true;
       }

       if (GoodLight1 && GoodLight2 && GoodLight3 && GoodLight4 && BadLight5 && BadLight6 && BadLight7 && BadLight8)
       {
           checkLight.Invoke();
       }
           
       
   }
}
