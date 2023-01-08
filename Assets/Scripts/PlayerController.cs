using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 5.0f;
    private float turnSpeed = 40f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        // Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moves car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates vehicle on its axis to replicate "turning"
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}




//testing speed up functionality
//public float currentSpeed = 0f;
//end of testing



//testing speed up functionality
/*        if (currentSpeed > speed){
            speed += .1f;
        }
        else
        {
            speed -= .1f;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            currentSpeed += 1;
        }
        else if (speed <= 5)
        {
            speed = 5;
        }
        else
        {
            if (currentSpeed > 0)
            {
            currentSpeed -= 1;
            }
        }*/
//end of testing
//-------------------------------------------------