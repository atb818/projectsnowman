using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerV1 : MonoBehaviour {

	//Movement
	float moveX;
	float moveZ;

	//Rotation
	public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float rotY = 0.0f;
    private float rotX = 0.0f;

    //Jumping
    public int jumpForce;
    public int groundDist;
    public bool isGrounded;
 	//private bool canJump;
 	//private bool canMove;
 	private Rigidbody rb;

 	void Start(){
	    rb = GetComponent<Rigidbody>();
	    moveX = 0;
	    moveZ = 0;
 	}

	void Update() {
	    /*if(Input.GetKeyDown(KeyCode.Space)){
        	canJump = true;
     	}*/
    }

    void FixedUpdate(){
    	GroundCheck();
    	Movement();
    	Jumping();
    }

    void GroundCheck(){
		if (Physics.Raycast(transform.position, Vector3.down, groundDist)){
			isGrounded = true;
			//canMove = true
            //Debug.Log("Can Jump");
		}
    }

    void Movement(){

    	if (isGrounded){
    		//Movement
        	moveX = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
        	moveZ = Input.GetAxis("Vertical") * Time.deltaTime * 10.0f;
    	}
        	transform.Translate(moveX, 0, moveZ);

        	//Rotation
        	rotY += speedH * Input.GetAxis("Mouse X");
        	//rotX -= speedV * Input.GetAxis("Mouse Y");
        	transform.eulerAngles = new Vector3(rotX, rotY, 0.0f);
    }

    void Jumping(){
    	if(isGrounded && Input.GetKeyDown(KeyCode.Space)){
        	rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        	isGrounded = false;
        	//canMove = false;
            Debug.Log("JUMP");
     	}
    }
}
