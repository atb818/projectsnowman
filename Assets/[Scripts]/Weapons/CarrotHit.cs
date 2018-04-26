using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotHit : MonoBehaviour {

	Rigidbody rb;

	void Start () {
		//transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
		rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
		
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.CompareTag("Player")){
			Destroy(this.gameObject);
		} else {
        	rb.isKinematic = true;
        	rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotationX;
        	rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
        	rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
        	Destroy(this.gameObject, 15);
		}
	}
}
