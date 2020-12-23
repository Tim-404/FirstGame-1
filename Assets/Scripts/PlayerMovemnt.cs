using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemnt : MonoBehaviour 
{

    public Rigidbody rb;
    public float forwardsForce = 2000f;
    public float sidewaysForce = 500f;

    // Use FixedUpdate because we are messing with physics
    void FixedUpdate() 
    {
        rb.AddForce(0, 0, forwardsForce * Time.deltaTime);
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-1 * sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
