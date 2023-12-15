using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce=200f;
    public float sidewardforce=20f;
   
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardforce*Time.deltaTime);

        if(Input.GetKey("a")){
            rb.AddForce(-sidewardforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        else if(Input.GetKey("d")){
            rb.AddForce(sidewardforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        else if(Input.GetKey("space")){
            rb.AddForce(0,sidewardforce*Time.deltaTime,0,ForceMode.VelocityChange);
        }
        
        if(rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
