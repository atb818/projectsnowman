using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMe : MonoBehaviour {

	public Transform me;
	public float upRotationLimit; //this will be a NEGATIVE number
	public float downRotationLimit; //this will be a POSITIVE number
	
	// Update is called once per frame
	void Update () {
		//transform.LookAt(me);
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, me.eulerAngles.y, 0.0f);  

		if (transform.eulerAngles.x < upRotationLimit && transform.eulerAngles.x > 180) {
			transform.eulerAngles = new Vector3 (upRotationLimit, transform.eulerAngles.y, transform.eulerAngles.z);
		}
		if (transform.eulerAngles.x > downRotationLimit && transform.eulerAngles.x < 180) {
			transform.eulerAngles = new Vector3 (downRotationLimit, transform.eulerAngles.y, transform.eulerAngles.z);
		}
	}
}
