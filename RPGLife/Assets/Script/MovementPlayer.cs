using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public Rigidbody rb;
    private float inputX;
    private float inputZ;
    private bool isGround;

    void Start()
    {
        
    }

    void Update()
    {
        Movement();
    }

    void Movement(){
        float speed = 0f;
        inputZ = Input.GetAxis("Vertical");
        inputX = Input.GetAxis("Horizontal");

        if(inputX != 0 || inputZ != 0){

            if(Input.GetKey(KeyCode.LeftShift)){

                speed = 0.08f; 

            }else speed = 0.04f;

        }else if(inputZ != 0 && inputX != 0){
            speed = 0.025f;
        }
        
        if(Input.GetKeyDown("space") && isGround == true){
            rb.AddForce(0,300,0);
        }

        transform.Translate(new Vector3((inputX * speed),0,(inputZ * speed)));
 
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "ground"){
            isGround = true;
        }  
    }

    

    void OnCollisionExit(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "ground"){
            isGround = false;
            return;
        }
    }

}
