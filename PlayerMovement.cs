// Modules
using UnityEngine;

// Unity Class
public class PlayerMovement : MonoBehaviour 
{
    // Variables
    public CharacterController2D controller;
    public float runSpeed;
    float horizontalMovement = 0f;
    bool jump = false;
    bool crouch = false;

    // Partical Referance
    public GameObject jumpEffeft;

    // Update to check if we hit these buttons
    public void Update()
    {
        // Get input 
        horizontalMovement = Input.GetAxisRaw("Horizontal") * runSpeed;  
        
        // Check if we hit the Jump bind
        if(Input.GetButtonDown("Jump"))
        {
            // Create Particals
            Instantiate(jumpEffeft, transform.position, Quaternion.identity); 
            jump = true;
        }

        // Check if we hit the Crouch bind
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if(Input.GetButtonUp("Crouch"))   
        {
            crouch = false;
        }
    }

    // If we jump JUMP
    public void FixedUpdate()
    {
        controller.Move(horizontalMovement * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

}
