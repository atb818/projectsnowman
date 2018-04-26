using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbitRotate : MonoBehaviour {

	public float lookUpMax;
	public float lookDownMax;
	public float speed;

	public bool canRotate;
	Vector2 mousePos;

	void Start () {
		canRotate = true;
	}
	
	void Update () {
		float _speed;
		/*
		if (Input.GetAxis("Vertical") < 0 && canRotate){
			//transform.eulerAngles = new Vector3 (transform.eulerAngles.x + speed, transform.eulerAngles.y, transform.eulerAngles.z);
			transform.Rotate(Input.GetAxis("Verttical") * speed, 0, 0);
		} else if (Input.GetAxis("Vertical") > 0 && canRotate){
			//transform.eulerAngles = new Vector3 (transform.eulerAngles.x - speed, transform.eulerAngles.y, transform.eulerAngles.z);
			transform.Rotate(Vector3.down);
		}

		if (Input.GetAxis("Vertical") == 0) {
			canRotate = false;
			mousePos = Input.mousePosition;
		} else {
			canRotate = true;
		}*/

		transform.Rotate(Input.GetAxis("Mouse Y") * -speed, 0, 0);

		if (transform.eulerAngles.x < lookUpMax && transform.eulerAngles.x > 180) {
			transform.eulerAngles = new Vector3 (lookUpMax, transform.eulerAngles.y, transform.eulerAngles.z);
		}
		if (transform.eulerAngles.x > lookDownMax && transform.eulerAngles.x < 180) {
			transform.eulerAngles = new Vector3 (lookDownMax, transform.eulerAngles.y, transform.eulerAngles.z);
		}
	}
}
