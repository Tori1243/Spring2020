using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerMover : MonoBehaviour
{
    private Vector3 position;
    //private Vector3 rotation;
    private CharacterController controller;
    
    public float moveSpeed = 300f, gravity = 9.81f, jumpSpeed = 30f;
    private int jumpCount;
    public int jumpCountMax = 2;
    public float SprintSpeed = 600f;
    public float WalkSpeed = 300f;
    public float RotationSpeed = 500f;
	

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //get input for running
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            // Changing speed variable
            moveSpeed = SprintSpeed; 
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = WalkSpeed;
        }
		
        // get input to stop running
        //Change speed variable
        position.x = moveSpeed*Input.GetAxis("Horizontal");
        position.z = moveSpeed*Input.GetAxis("Vertical");
        position.y -= gravity;

        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
            //transform.Rotate(RotationSpeed);
        }
        
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
        
        controller.Move(position*Time.deltaTime);
    }
}