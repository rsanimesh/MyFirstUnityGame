using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a refrence to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 50f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // We marked this as "Fixed"Update because we 
        // are using it to mess with physics.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
