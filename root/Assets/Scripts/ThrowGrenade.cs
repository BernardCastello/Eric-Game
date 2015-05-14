using UnityEngine;
using System.Collections;
/// <summary>
/// to throw the grenade object we'll need a sphere rigidbody.

// will need to add a force to the grenade object to launch it 
// into the air in the direction the player is facing.

// at start set grenade button to 'G'
// grenade button is set to 'G'
// if 'G' is pressed, spawn a grenade and call AddForce
// if 'G' is not pressed do nothing.
/// <summary>
public class ThrowGrenade : MonoBehaviour 
{
   
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {

        // This should only happen once!
        if (Input.GetKeyDown(KeyCode.G) && transform.parent)
        {           
            rb.isKinematic = false;

            rb.AddForce(Camera.main.transform.up * 450);
            rb.AddForce(Camera.main.transform.forward * 450);
            //rb.AddForce(transform.forward * 450);

            transform.parent = null;
        }
        //print("bounce");
    }
}
