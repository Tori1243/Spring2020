using UnityEngine;

public class LightChanger : MonoBehaviour {

    public GameObject light;
    private bool on = false;
    public int BallLightNumber;
    public CheckForLight checkForLight;

    // Use this for initialization
    void OnTriggerStay(Collider plyr) {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !on)
        {
            light.SetActive(true);
            checkForLight.CheckLightOn(BallLightNumber);
            on = true;
            
        }
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && on)
        {
            light.SetActive(false);
            on = false;
        }
        
    }
    
}