using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private CharacterController Controller;

    public float Gravity = 9.81f;
    public float MoveSpeed = 3.0f;
    public float JumpSpeed = 4.0f;
    private Vector3 rot;
    private Vector3 position;

    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Controller.isGrounded)
        {
            position.Set(MoveSpeed * Input.GetAxis("Horizontal"), 0, MoveSpeed * Input.GetAxis("Vertical"));
            position = transform.TransformDirection(position);
            print(position);
            rot.y = 180;
            
      //  if (Input.GetKey(KeyCode.RightArrow))
         //   {
          //      rot.y = 180;
          //      transform.rotation = Quaternion.Euler(rot);
          //  }

           // if (Input.GetKey(KeyCode.LeftArrow))
          //  {
               // rot.y = 0;
              //  transform.rotation = Quaternion.Euler(rot);
        //    }
            // ^^ these are broken for now :(

         if (Input.GetButton("Jump"))
              {
               position.y = JumpSpeed;
              }
        }
        
        position.y -= Gravity * Time.deltaTime;
        Controller.Move(position * Time.deltaTime);
       
    } 
}
