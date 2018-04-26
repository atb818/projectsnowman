using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotateControls : MonoBehaviour {

	//private Vector3 mousePos;

	public GameObject target;

	public float speedH = 2.0f;
	public float speedV = 2.0f;
	//For METHOD 2/3
    //private float rotY = 0.0f;
    //private float rotX = 0.0f;
    //For METHOD 4
    float rotY;
    float rotX;
    float speed = 2;

	void Start () {
		
	}
	
	void Update () {
		//METHOD 1
		/*
		mousePos.x = Input.mousePosition.x;
		mousePos.y = Input.mousePosition.y;

		if (Input.mousePosition.x < mousePos.x){
			//rotate left on y axis
		} else if (Input.mousePosition.x > mousePos.x){
			//rotate right on y axis	
		} else if (Input.mousePosition.x == mousePos.x){
				//do nothing
		}

		if (Input.mousePosition.y < mousePos.y){
			//rotate left on x axis
		} else if (Input.mousePosition.y > mousePos.y){
			//rotate right on x axis	
		} else if (Input.mousePosition.y == mousePos.y){
				//do nothing
		}
		*/

		//METHOD 2
		/*
		if(Input.GetAxis("Mouse X") == -1){
			rotY += speedH * Input.GetAxis("Mouse X");
        	rotX -= speedV * Input.GetAxis("Mouse Y");
			transform.eulerAngles = new Vector3(rotX, rotY, 0.0f);        
		}
        if(Input.GetAxis("Mouse X") == 1){
            //play animation for right move
        }
        */

        //METHOD 3
        /*
		//rotY += speedH * Input.GetAxis("Mouse X");
    	rotX -= speedV * Input.GetAxis("Mouse Y");
		transform.eulerAngles = new Vector3(rotX, rotY, 0.0f); */

		//METHOD 4 

		/*if (Input.GetAxis("Mouse X") == 1){
			rotY = 1;
		} else if (Input.GetAxis("Mouse X") == -1){
			rotY = -1;
		}*/

		float _speed;

		if (Input.GetAxis("Mouse Y") == -1){
			rotX = 1;
		} else if (Input.GetAxis("Mouse Y") == 1){
			rotX = -1;
		}

		if (Input.GetAxis("Mouse Y") == 0) {
			_speed = 0;
		} else {
			_speed = speed;
		}

		transform.RotateAround(target.transform.position, new Vector3 (rotX, rotY, 0), _speed);

		if (transform.eulerAngles.x < 300 && transform.eulerAngles.x > 180) {
			transform.eulerAngles = new Vector3 (300, transform.eulerAngles.y, transform.eulerAngles.z);
		}
		if (transform.eulerAngles.x > 60 && transform.eulerAngles.x < 180) {
			transform.eulerAngles = new Vector3 (60, transform.eulerAngles.y, transform.eulerAngles.z);
		}


	}
}
