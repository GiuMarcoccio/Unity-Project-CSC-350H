using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked this as "FixedUpdate" because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        // To the rigth
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // To the left
        if (Input.GetKey("a"))
        {
            rb.AddForce((-sidewaysForce*2) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Reduce Player Velocity
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, (-forwardForce-400) * Time.deltaTime);
        }

        // Increase Player Velocity
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, (forwardForce + 900) * Time.deltaTime);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

/*  
    
    Which view enables you to manipulate objects in a scene visually?
    
    R: The Scene View
    
    Project View, scene view, game view or Inspector View or Hierarchy View?
    
    R: 
    
    How many game objects did you create? Are assets and game objects the same?
    
    R: 113 game objects. An asset is something you created that you're loading into your program and an object is a programming construct
    
    What happens if you double the value of rightForce? why?
    
    R: The rightForce will be incremented by the double of its actual value causing that the force to the right is more than the left force. 
    
    What is the class you have created in the Unity project?How many instance variables are there in the class?
    
    R: PlayerMovement is the class  that I created in the project and I used 3 instances variables
    
    What is a rigidbody?
    
    R: "Rigidbodies enable your GameObjects to act under the control of physics. The Rigidbody can receive forces and torque to make your objects
        move in a realistic way. Any GameObject must contain a Rigidbody to be influenced by gravity, act under added forces via scripting, or interact 
        with other objects through the NVIDIA PhysX physics engineA system that simulates aspects of physical systems so that objects can accelerate 
        correctly and be affected by collisions, gravity and other forces. More info See in Glossary." Unity Documentation. Rigidbody allows to receives 
        diferentes aspects of real-life and apply them into our game. 

    How do you modify your code to allow users to press 'w' to speed up, and press 'x' to slow down the object's movement? please include this feature in your video to show your work and code.
    
    R: Very easy, taking the variable instance of fowardForce and taking the z-axis as main parameter to increment or decrease the velocity.

        // Reduce Player Velocity
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, (-forwardForce-300) * Time.deltaTime);
        }

        // Increase Player Velocity
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, (forwardForce + 900) * Time.deltaTime);
        }
*/
