using UnityEngine;
public class FlippityFlip: MonoBehaviour {

private Vector3 rot;

        private void Update()
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rot.y = 180;
                transform.rotation = Quaternion.Euler(rot);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rot.y = 0;
                transform.rotation = Quaternion.Euler(rot);
            }
        }
 }
