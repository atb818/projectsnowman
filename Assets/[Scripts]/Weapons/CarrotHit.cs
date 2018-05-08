using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotHit : MonoBehaviour {

	Rigidbody rb;

	void Start () {
		//transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
		StartCoroutine("ColliderDelay");
		rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
		
	}

	void OnCollisionEnter (Collision col) {
		Debug.Log("Carrot Hit");
		/*if (col.gameObject.CompareTag("Player")){
			Destroy(this.gameObject);
		} else {
			
        	//rb.isKinematic = true;
        	//rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotationX;
        	//rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
        	//rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
        	
        	rb.velocity = new Vector3(0, 0, 0);
        	Destroy(this.gameObject, 15);
		}*/
		if (col.gameObject.CompareTag("Player")){
			Destroy(gameObject);
		} else {
			rb.isKinematic = true;
			rb.velocity = Vector3.zero;
			Destroy(gameObject, 10);
		}
	}

	IEnumerator ColliderDelay(){
		GetComponent<Collider>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<Collider>().enabled = true;
	}
}
