using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    
    //maybe just use movementSpeed as rotations also?
    public float movementSpeed = 10;
    public float rotationSpeed = 5;
    public float rotationDegrees = 90;

    // gets the rigidbody component of the player asset
    void Start () {

        rb = GetComponent<Rigidbody>();
        
    }
	
	// used fixed update in case of lagg
	void FixedUpdate () {
        
        //mouse x-axis input
        //float mouseX = Input.GetAxis("Mouse X");


        //mouseButtonUp if we want more like a trigger feel
        //if(Input.GetMouseButtonUp(0))

        //getkey if we want fire extinguisher 
        //if (Input.GetKey(KeyCode.Mouse0))
        //{

        //    //rb.position += Vector3.back * Time.deltaTime * movementSpeed; --- wrong one
        //    rb.position += transform.forward * -1 * Time.deltaTime * movementSpeed;

        //}
        //else

        //    rb.transform.Rotate(0f, mouseX, 0f);

        //wad 
        //if(Input.GetButtonUp("W"))
        if (Input.GetKey(KeyCode.W))
        {
            //-1 for the inverse transform forward
            rb.position += transform.forward * -1 * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.transform.Rotate(0f, rotationDegrees * Time.deltaTime * rotationSpeed, 0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Rotate(0f, -(rotationDegrees) * Time.deltaTime * rotationSpeed, 0f);
        }



    }

    

    }

    

