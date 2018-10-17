using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;
    public PlayerCollision collision;
    public Teleport swap;

	public float forwardForce = 2000f;	// Variable that determines the forward force
	public float sidewaysForce = 500f;  // Variable that determines the sideways force
    public float upForce = 100f;
    public float downForce = 100f;
    public float torque = 2f;

	// We marked this as "Fixed"Update because we
	// are using it to mess with physics.
	void FixedUpdate ()
	{
		// Add a forward force
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (!Input.anyKey)
        {
            rb.angularVelocity = Vector3.zero;
        }
        forwardForce += 1;
		if (Input.GetKey("d"))	// If the player is pressing the "d" key
		{
			// Add a force to the right
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddRelativeTorque(0, 0, -torque);
		}

		if (Input.GetKey("a"))  // If the player is pressing the "a" key
		{
			// Add a force to the left
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddRelativeTorque(0, 0, torque);
		}

        if (Input.GetKey("w")) {
            rb.AddForce(0, upForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            rb.AddRelativeTorque(-torque / (sidewaysForce / upForce), 0, 0);
        } 

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -downForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            rb.AddRelativeTorque(torque / (sidewaysForce / downForce), 0, 0);
        }

        if (Input.GetKey("q")) {
            rb.rotation = Quaternion.identity;
        }
        
        if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}

    public void moveRight() {
        rb.transform.Translate(100, 0, 0);
    }

    public void moveLeft() {
        rb.transform.Translate(-100, 0, 0);
    }
}
